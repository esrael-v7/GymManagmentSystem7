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
    public partial class uc_AddPayment : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        private MainDashboard _mainForm;
        private int _editingPaymentId = -1;
        public uc_AddPayment(MainDashboard form)
        {
            InitializeComponent();
            _mainForm = form;
            LoadMembersToComboBox();
            this.MouseDown += new MouseEventHandler(uc_AddPayment_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_AddPayment_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_AddPayment_MouseUp);
        }
            private void uc_AddPayment_Load(object sender, EventArgs e)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = "SELECT MemberId, FirstName + ' ' + LastName AS FullName FROM Member";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    namelistcombo.DataSource = dt;
                    namelistcombo.DisplayMember = "FullName";
                    namelistcombo.ValueMember = "MemberId";
                }
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_AddPayment_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_AddPayment_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_AddPayment_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void LoadMembersToComboBox()
        {
            namelistcombo.DisplayMember = "Text";
            namelistcombo.ValueMember = "Value";
            namelistcombo.Items.Clear();

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"SELECT m.MemberId, m.FirstName + ' ' + m.LastName AS FullName
                               FROM Member m
                               INNER JOIN Account a ON m.AccountId = a.AccountId
                               WHERE a.Status = 'A'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namelistcombo.Items.Add(new
                        {
                            Text = reader["FullName"].ToString(),
                            Value = Convert.ToInt32(reader["MemberId"])
                        });
                    }
                }
            }

            if (namelistcombo.Items.Count > 0)
                namelistcombo.SelectedIndex = 0;
        }
        private void btnupdatepayment464_Click(object sender, EventArgs e)
        {
            if (_editingPaymentId == -1)
            {
                MessageBox.Show("No payment selected for update.");
                return;
            }

            int memberId = Convert.ToInt32(namelistcombo.SelectedValue);

            decimal amount = decimal.TryParse(txtAM.Text.Trim(), out decimal parsed) ? parsed : 0;
            DateTime paymentDate = DTP1.Value;

            if (amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"UPDATE Payment 
                               SET MemberId = @MemberId, Amount = @Amount, PaymentDate = @Date
                               WHERE PaymentId = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Date", paymentDate);
                cmd.Parameters.AddWithValue("@Id", _editingPaymentId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment updated.");
                _mainForm.LoadPaymentsToGrid();
                this.Dispose();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

          
        }

        private void label3_Click(object sender, EventArgs e)
        {

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (namelistcombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a member.");
                return;
            }

            // Safely extract MemberId using dynamic type
            dynamic selectedItem = namelistcombo.SelectedItem;
            int memberId = Convert.ToInt32(((DataRowView)namelistcombo.SelectedItem)["MemberId"]);


            if (!decimal.TryParse(txtAM.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            DateTime paymentDate = DTP1.Value;

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"INSERT INTO Payment (MemberId, Amount, PaymentDate)
                       VALUES (@MemberId, @Amount, @Date)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Date", paymentDate);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment recorded successfully.");
                _mainForm.LoadPaymentsToGrid();
                this.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void label2_Click(object sender, EventArgs e)
        {

          
        }
        public void LoadPaymentForEdit(int paymentId, int memberId, decimal amount, DateTime paymentDate)
        {
            _editingPaymentId = paymentId;

            // This works if ValueMember = "MemberId" is properly set during ComboBox binding
            namelistcombo.SelectedValue = memberId;

            txtAM.Text = amount.ToString("F2");
            DTP1.Value = paymentDate;

            btnA.Visible = false;
            btnupdatepayment464.Visible = true;
        }

    }
}