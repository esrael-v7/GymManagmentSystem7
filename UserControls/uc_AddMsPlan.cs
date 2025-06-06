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
using GymManagementSystem7.Models;
using GymManagmentSystem7.Controller;
using GymManagmentSystem7.Models;
using Microsoft.Data.SqlClient;
using GymManagmentSystem7.DB;


namespace GymManagmentSystem7.UserControls
{
    public partial class uc_AddMsPlan : UserControl
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragControlPoint;
        private int _editingPlanId = -1;
        private MainDashboard _mainForm;
        private int _loggedInTrainerId;

        public uc_AddMsPlan(MainDashboard form, int trainerId)
        {
            InitializeComponent();
            _mainForm = form;
            _loggedInTrainerId = trainerId;

            this.MouseDown += new MouseEventHandler(uc_viewMsPlan_MouseDown);
            this.MouseMove += new MouseEventHandler(uc_viewMsPlan_MouseMove);
            this.MouseUp += new MouseEventHandler(uc_viewMsPlan_MouseUp);
            this.Load += new System.EventHandler(this.uc_AddMsPlan_Load);


        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void uc_viewMsPlan_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragControlPoint = this.Location;
        }

        private void uc_viewMsPlan_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragControlPoint, new Size(diff));
            }
        }

        private void uc_viewMsPlan_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void uc_AddMsPlan_Load(object sender, EventArgs e)
        {
            // 👇 Load members into ComboBox
            using (var conn = new DBConnection()._Connect)
            {
                var sql = "SELECT MemberId, FirstName + ' ' + LastName AS FullName FROM Member";
                var cmd = new SqlCommand(sql, conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                cmbmember4.DisplayMember = "FullName";
                cmbmember4.ValueMember = "MemberId";
                cmbmember4.DataSource = table;
            }

            // 👇 Set default values for Duration and Date
            nudduration2.Value = 4; // e.g. 4 weeks
            dtpdate2.Value = DateTime.Today;
        }

        private void btnaddmemb2_Click(object sender, EventArgs e)
        {
            var plan = new WorkoutPlan
            {
                MemberId = (int)cmbmember4.SelectedValue,
                TrainerId = _loggedInTrainerId, // make sure it's passed from MainDashboard
                Duration = nudduration2.Value.ToString(),
                AssignedDate = dtpdate2.Value
            };

            var controller = new TrainerController();
            if (controller.AddPlan(plan))
            {
                MessageBox.Show("Workout plan added successfully!");
                _mainForm.LoadPlansToGrid();  // refresh DataGridView
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Failed to add workout plan.");
            }

        }

        private void updabtn_Click(object sender, EventArgs e)
        {
            if (_editingPlanId == -1)
            {
                MessageBox.Show("No workout plan selected for update.");
                return;
            }

            int memberId = (int)cmbmember4.SelectedValue;
            string duration = nudduration2.Value.ToString();
            DateTime date = dtpdate2.Value;

            var controller = new TrainerController();
            if (controller.UpdatePlan(_editingPlanId, memberId, duration, date))
            {
                MessageBox.Show("Workout plan updated.");
                _mainForm.LoadPlansToGrid();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }
        public void LoadPlanForEdit(int planId, int memberId, string duration, DateTime assignedDate)
        {
            _editingPlanId = planId;
            cmbmember4.SelectedValue = memberId;
            nudduration2.Value = int.TryParse(duration, out int dur) ? dur : 0;
            dtpdate2.Value = assignedDate;

            btnaddmemb2.Visible = false;
            updabtn.Visible = true;
        }


    }
}

