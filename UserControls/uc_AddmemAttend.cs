using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManagmentSystem7.Controllers;
using GymManagmentSystem7.Models;
using Microsoft.VisualBasic;
using GymManagementSystem7.Models;
using GymManagmentSystem7.DB;
using Microsoft.Data.SqlClient;

namespace GymManagmentSystem7.UserControls
{
    public partial class uc_AddmemAttend : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        private MainDashboard _mainForm;
        private int _loggedInTrainerId;
        private int _editingAttendanceId = -1;
        public uc_AddmemAttend(MainDashboard form, int trainerId)
        {
            InitializeComponent();
            _mainForm = form;
            _loggedInTrainerId = trainerId;

            this.MouseDown += new MouseEventHandler(uc_AddmemAttend_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_AddmemAttend_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_AddmemAttend_MouseUp);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_AddmemAttend_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_AddmemAttend_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_AddmemAttend_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void labMsAddAttend7_Click(object sender, EventArgs e)
        {
            if (cmbMember84.SelectedItem == null || cmbStatus84.SelectedItem == null)
            {
                MessageBox.Show("Select member and status.");
                return;
            }

            int memberId = (int)cmbMember84.SelectedValue;
            string status = cmbStatus84.SelectedItem.ToString();
            DateTime date = dtpDate84.Value;

            var controller = new TrainerController();
            var attendance = new Attendance
            {
                MemberId = memberId,
                TrainerId = _loggedInTrainerId,  // Pass this from MainDashboard
                Date = date,
                Status = status
            };

            if (controller.AddAttendance(attendance))
            {
                MessageBox.Show("Attendance added.");
                _mainForm.LoadMsAttendance(); // Refresh grid in Trainer tab
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Failed to add.");
            }
        }

        private void uc_AddmemAttend_Load(object sender, EventArgs e)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"SELECT MemberId, FirstName + ' ' + LastName AS FullName FROM Member";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbMember84.DisplayMember = "FullName";
                cmbMember84.ValueMember = "MemberId";
                cmbMember84.DataSource = dt;
            }

            cmbStatus84.Items.Clear();
            cmbStatus84.Items.Add("P");
            cmbStatus84.Items.Add("A");
            cmbStatus84.SelectedIndex = 0;
        }
        public void LoadAttendanceForEdit(int attendanceId, int memberId, DateTime date, string status)
        {
            _editingAttendanceId = attendanceId;
            cmbMember84.SelectedValue = memberId;
            dtpDate84.Value = date;
            cmbStatus84.SelectedItem = status;

            labMsAddAttend7.Visible = false;
            Updateattendbtn11.Visible = true;
        }

        private void Updateattendbtn11_Click(object sender, EventArgs e)
        {
            if (_editingAttendanceId == -1)
            {
                MessageBox.Show("No attendance selected.");
                return;
            }

            int memberId = (int)cmbMember84.SelectedValue;
            DateTime date = dtpDate84.Value;
            string status = cmbStatus84.SelectedItem?.ToString() ?? "A";

            var conn = new DBConnection()._Connect;
            string sql = @"UPDATE Attendance SET MemberId = @MemberId, Date = @Date, Status = @Status 
                   WHERE AttendanceId = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Id", _editingAttendanceId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Attendance updated.");
            _mainForm.LoadMsAttendance();
            this.Dispose();
        }
    }
}
