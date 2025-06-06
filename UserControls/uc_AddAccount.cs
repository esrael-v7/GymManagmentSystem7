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
    public partial class uc_AddAccount : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        public uc_AddAccount()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(uc_AddAccount_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_AddAccount_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_AddAccount_MouseUp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_AddAccount_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_AddAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_AddAccount_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {

            string username = txtusername1.Text.Trim();
            string password = txtPassword1.Text.Trim();
            string role = cmbRole1.SelectedItem.ToString();
            string status = cmbStatus1.SelectedItem?.ToString() ?? "A";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }

            using (SqlConnection conn = new DBConnection()._Connect)
            {
                string checkSql = "SELECT COUNT(*) FROM Account WHERE Username = @Username";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@Username", username);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }

                string insertSql = @"INSERT INTO Account (AccountGuid, Username, Password, Role, Status)
                             VALUES (@Guid, @Username, @Password, @Role, @Status)";
                SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                insertCmd.Parameters.AddWithValue("@Guid", Guid.NewGuid());
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password);
                insertCmd.Parameters.AddWithValue("@Role", role);
                insertCmd.Parameters.AddWithValue("@Status", status);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully.");
            }
        }

        private void uc_AddAccount_Load(object sender, EventArgs e)
        {
            cmbRole1.Items.Clear();
            cmbRole1.Items.Add("Admin");
            cmbRole1.Items.Add("Cashier");
            cmbRole1.SelectedIndex = 0;

            //  Status ComboBox
            cmbStatus1.Items.Clear();
            cmbStatus1.Items.Add("A");
            cmbStatus1.Items.Add("D");
            cmbStatus1.SelectedIndex = 0;
        }

        private void cmbRole1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

