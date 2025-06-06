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
    public partial class uc_AddMember : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        private MainDashboard _mainForm;
        private int _editingMemberId = -1;

        public uc_AddMember(MainDashboard form)
        {
            InitializeComponent();
            _mainForm = form;
            Btnupdate48.Visible = false;
            btnsave39.Visible = true;
            txtusername48.ReadOnly = true;
            txtpassword48.ReadOnly = true;
            txtAge.ReadOnly = true;



            this.MouseDown += new MouseEventHandler(uc_AddMember_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_AddMember_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_AddMember_MouseUp);
        }

        public void LoadMemberForEdit(int memberId, string FirstName, string LastName, string Gender, string Age, string MemberShipType)
        {
            _editingMemberId = memberId;

            txtFname.Text = FirstName;
            txtLName.Text = LastName;
            txtAge.Text = Age;
            cmbgend48.SelectedItem = Gender;
            Memshipcombo1.SelectedItem = MemberShipType;

            btnsave39.Visible = false;
            Btnupdate48.Visible = true;
        }
        private void uc_AddMember_Load(object sender, EventArgs e)
        {

            // Populate Gender ComboBox
            cmbgend48.Items.Clear();
            cmbgend48.Items.Add("Male");
            cmbgend48.Items.Add("Female");
            cmbgend48.Items.Add("Other");
            cmbgend48.SelectedIndex = 0;

            // Populate Membership-Type ComboBox
            Memshipcombo1.Items.Clear();
            Memshipcombo1.Items.Add("Basic");
            Memshipcombo1.Items.Add("Premium");
            Memshipcombo1.Items.Add("VIP");
            Memshipcombo1.Items.Add("Student");
            Memshipcombo1.SelectedIndex = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_AddMember_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_AddMember_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_AddMember_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnsave39_Click(object sender, EventArgs e)
        {
            string firstName = txtFname.Text.Trim();
            string lastName = txtLName.Text.Trim();
            string gender = cmbgend48.SelectedItem?.ToString() ?? "";
            string membershipType = Memshipcombo1.SelectedItem?.ToString() ?? "";
            int age = CalculateAge(dtpage25.Value);  // ✅ FIXED: calculate age from birth date picker

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please complete all required fields.");
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
                    // Create Account
                    string insertAccount = @"INSERT INTO Account (AccountGuid, Username, Password, Role, Status)
                                     OUTPUT INSERTED.AccountId
                                     VALUES (@Guid, @Username, @Password, @Role, @Status)";
                    SqlCommand accCmd = new SqlCommand(insertAccount, conn, trans);
                    accCmd.Parameters.AddWithValue("@Guid", Guid.NewGuid());
                    accCmd.Parameters.AddWithValue("@Username", username);
                    accCmd.Parameters.AddWithValue("@Password", password);
                    accCmd.Parameters.AddWithValue("@Role", "Member");
                    accCmd.Parameters.AddWithValue("@Status", "A");

                    int accountId = (int)accCmd.ExecuteScalar();

                    // Create Member
                    string insertMember = @"INSERT INTO Member (FirstName, LastName, Gender, Age, MembershipType, AccountId)
                                    VALUES (@FirstName, @LastName, @Gender, @Age, @MembershipType, @AccountId)";
                    SqlCommand memberCmd = new SqlCommand(insertMember, conn, trans);
                    memberCmd.Parameters.AddWithValue("@FirstName", firstName);
                    memberCmd.Parameters.AddWithValue("@LastName", lastName);
                    memberCmd.Parameters.AddWithValue("@Gender", gender);
                    memberCmd.Parameters.AddWithValue("@Age", age);
                    memberCmd.Parameters.AddWithValue("@MembershipType", membershipType);
                    memberCmd.Parameters.AddWithValue("@AccountId", accountId);

                    memberCmd.ExecuteNonQuery();

                    trans.Commit();

                    MessageBox.Show($"Member and account created!\n\nUsername: {username}\nPassword: {password}");

                    _mainForm.LoadMembersToGrid();
                    this.Dispose();
                    ClearForm();
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
            int suffix = new Random().Next(100, 999);  // Random 3-digit number
            return baseUsername + suffix;
        }

        private string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ClearForm()
        {
            txtFname.Clear();
            txtLName.Clear();
            txtAge.Clear();
            txtusername48.Clear();
            txtpassword48.Clear();
            cmbgend48.SelectedIndex = -1;
            Memshipcombo1.SelectedIndex = -1;
        }

        private void Btnupdate48_Click(object sender, EventArgs e)
        {
            if (_editingMemberId == -1)
            {
                MessageBox.Show("No member selected for update.");
                return;
            }

            string firstName = txtFname.Text.Trim();
            string lastName = txtLName.Text.Trim();
            string gender = cmbgend48.SelectedItem?.ToString() ?? "";
            string membershipType = Memshipcombo1.SelectedItem?.ToString() ?? "";
            int age = CalculateAge(dtpage25.Value); // ✅ calculate from birthdate picker

            string username = txtusername48.Text.Trim();
            string password = txtpassword48.Text.Trim();

            // ✅ Allow updates with partial fields
            if (string.IsNullOrWhiteSpace(firstName) &&
                string.IsNullOrWhiteSpace(lastName) &&
                string.IsNullOrWhiteSpace(gender) &&
                string.IsNullOrWhiteSpace(membershipType) &&
                string.IsNullOrWhiteSpace(username) &&
                string.IsNullOrWhiteSpace(password) &&
                age <= 0)
            {
                MessageBox.Show("Please update at least one field.");
                return;
            }

            using (var conn = new DBConnection()._Connect)
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // Get linked AccountId
                    int accountId = -1;
                    string getAccountIdSql = "SELECT AccountId FROM Member WHERE MemberId = @MemberId";
                    using (SqlCommand getAccCmd = new SqlCommand(getAccountIdSql, conn, trans))
                    {
                        getAccCmd.Parameters.AddWithValue("@MemberId", _editingMemberId);
                        object result = getAccCmd.ExecuteScalar();
                        if (result != null)
                            accountId = Convert.ToInt32(result);
                        else
                            throw new Exception("Account ID not found for this member.");
                    }

                    // 🔄 Dynamic Account Update
                    var accParts = new List<string>();
                    var accCmd = new SqlCommand();
                    accCmd.Connection = conn;
                    accCmd.Transaction = trans;

                    if (!string.IsNullOrWhiteSpace(username))
                    {
                        accParts.Add("Username = @Username");
                        accCmd.Parameters.AddWithValue("@Username", username);
                    }
                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        accParts.Add("Password = @Password");
                        accCmd.Parameters.AddWithValue("@Password", password);
                    }

                    if (accParts.Count > 0)
                    {
                        accCmd.Parameters.AddWithValue("@AccountId", accountId);
                        accCmd.CommandText = $"UPDATE Account SET {string.Join(", ", accParts)} WHERE AccountId = @AccountId";
                        accCmd.ExecuteNonQuery();
                    }

                    // 🔄 Dynamic Member Update
                    var memParts = new List<string>();
                    var memCmd = new SqlCommand();
                    memCmd.Connection = conn;
                    memCmd.Transaction = trans;

                    if (!string.IsNullOrWhiteSpace(firstName))
                    {
                        memParts.Add("FirstName = @FirstName");
                        memCmd.Parameters.AddWithValue("@FirstName", firstName);
                    }
                    if (!string.IsNullOrWhiteSpace(lastName))
                    {
                        memParts.Add("LastName = @LastName");
                        memCmd.Parameters.AddWithValue("@LastName", lastName);
                    }
                    if (!string.IsNullOrWhiteSpace(gender))
                    {
                        memParts.Add("Gender = @Gender");
                        memCmd.Parameters.AddWithValue("@Gender", gender);
                    }
                    if (!string.IsNullOrWhiteSpace(membershipType))
                    {
                        memParts.Add("MembershipType = @MembershipType");
                        memCmd.Parameters.AddWithValue("@MembershipType", membershipType);
                    }
                    if (age > 0)
                    {
                        memParts.Add("Age = @Age");
                        memCmd.Parameters.AddWithValue("@Age", age);
                    }

                    if (memParts.Count > 0)
                    {
                        memCmd.Parameters.AddWithValue("@MemberId", _editingMemberId);
                        memCmd.CommandText = $"UPDATE Member SET {string.Join(", ", memParts)} WHERE MemberId = @MemberId";
                        memCmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Member updated successfully!");
                    _mainForm.LoadMembersToGrid();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Update failed: " + ex.Message);
                }
            }
        }
        
        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpage25_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dtpage25.Value;
            int age = CalculateAge(birthDate);
            txtAge.Text = age.ToString();
        }
        private int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) age--; // Adjust for birth month/day

            return age;
        }

    }
}

