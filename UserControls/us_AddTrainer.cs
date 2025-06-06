using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using GymManagmentSystem7.DB;


namespace GymManagmentSystem7.UserControls
{
    public partial class us_AddTrainer : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        private MainDashboard _mainForm;
        private int _editingTrainerId = -1;
        public us_AddTrainer(MainDashboard form)
        {
            InitializeComponent();
            _mainForm = form;

            // Optional visibility settings
            btnSaveTrain32.Visible = true;
            btnupdatetrain90.Visible = false;

            this.MouseDown += new MouseEventHandler(us_AddTrainer_MouseDown);
            this.MouseMove += new MouseEventHandler(us_AddTrainer_MouseMove);
            this.MouseUp += new MouseEventHandler(us_AddTrainer_MouseUp);
            this.Load += new System.EventHandler(this.us_AddTrainer_Load);



        }
        public void LoadTrainerForEdit(int trainerId, string firstName, string lastName, string specialization)
        {
            _editingTrainerId = trainerId;
            txtTfirstname.Text = firstName;
            txtTlastname.Text = lastName;
            cmbSpecialization.SelectedItem = specialization;

            btnSaveTrain32.Visible = false;
            btnupdatetrain90.Visible = true;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void us_AddTrainer_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void us_AddTrainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void us_AddTrainer_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnSaveTrain32_Click(object sender, EventArgs e)
        {
            string firstName = txtTfirstname.Text.Trim();
            string lastName = txtTlastname.Text.Trim();
            string specialization = cmbSpecialization.SelectedItem?.ToString() ?? "";



            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(specialization))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            // Auto-generate username and password
            string username = GenerateUsername(firstName, lastName);
            string password = GeneratePassword();

            using (var conn = new DBConnection()._Connect)
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // Insert into Account
                    string insertAccount = @"INSERT INTO Account (AccountGuid, Username, Password, Role, Status)
                                 OUTPUT INSERTED.AccountId
                                 VALUES (@Guid, @Username, @Password, @Role, @Status)";
                    SqlCommand accCmd = new SqlCommand(insertAccount, conn, trans);
                    accCmd.Parameters.AddWithValue("@Guid", Guid.NewGuid());
                    accCmd.Parameters.AddWithValue("@Username", username);
                    accCmd.Parameters.AddWithValue("@Password", password);
                    accCmd.Parameters.AddWithValue("@Role", "Trainer");
                    accCmd.Parameters.AddWithValue("@Status", "A");
                    int accountId = (int)accCmd.ExecuteScalar();

                    // Insert into Trainer
                    string insertTrainer = @"INSERT INTO Trainer (FirstName, LastName, Specialization, AccountId)
                                 VALUES (@FirstName, @LastName, @Specialization, @AccountId)";
                    SqlCommand trainerCmd = new SqlCommand(insertTrainer, conn, trans);
                    trainerCmd.Parameters.AddWithValue("@FirstName", firstName);
                    trainerCmd.Parameters.AddWithValue("@LastName", lastName);
                    trainerCmd.Parameters.AddWithValue("@Specialization", specialization);
                    trainerCmd.Parameters.AddWithValue("@AccountId", accountId);
                    trainerCmd.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show($"Trainer created!\n\nUsername: {username}\nPassword: {password}");
                    this.Dispose(); // close user control
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private string GenerateUsername(string firstName, string lastName)
        {
            string baseUsername = (firstName + "." + lastName).ToLower();
            int suffix = new Random().Next(100, 999); // e.g., john.smith123
            return baseUsername + suffix;
        }

        private string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnupdatetrain90_Click(object sender, EventArgs e)
        {

            if (_editingTrainerId == -1)
            {
                MessageBox.Show("No trainer selected.");
                return;
            }

            string firstName = txtTfirstname.Text.Trim();
            string lastName = txtTlastname.Text.Trim();
            string specialization = cmbSpecialization.SelectedItem?.ToString() ?? "";


            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName) && string.IsNullOrWhiteSpace(specialization))
            {
                MessageBox.Show("Please update at least one field.");
                return;
            }

            using (var conn = new DBConnection()._Connect)
            {
                var updates = new List<string>();
                var cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    updates.Add("FirstName = @FirstName");
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                }
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    updates.Add("LastName = @LastName");
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                }
                if (!string.IsNullOrWhiteSpace(specialization))
                {
                    updates.Add("Specialization = @Specialization");
                    cmd.Parameters.AddWithValue("@Specialization", specialization);
                }

                if (updates.Count > 0)
                {
                    cmd.CommandText = $"UPDATE Trainer SET {string.Join(", ", updates)} WHERE TrainerId = @_id";
                    cmd.Parameters.AddWithValue("@_id", _editingTrainerId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainer updated successfully!");
                    _mainForm.LoadTrainersToGrid();
                    this.Dispose();
                }
            }
        }

        private void us_AddTrainer_Load(object sender, EventArgs e)
        {
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList; // optional
            cmbSpecialization.Items.Clear();
            cmbSpecialization.Items.Add("Strength & Conditioning Coach");
            cmbSpecialization.Items.Add("Fat Loss & Metabolic Specialist");
            cmbSpecialization.Items.Add("Post-Rehab & Corrective Exercise Trainer");
            cmbSpecialization.Items.Add("Sports-Specific Performance Coach");
            cmbSpecialization.Items.Add("Senior Fitness & Active Aging Specialist");

            cmbSpecialization.SelectedIndex = 0; // optional
        }
    }
}

