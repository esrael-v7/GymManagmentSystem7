using GymManagementSystem7.Models;
using GymManagmentSystem7.Controller;
using GymManagmentSystem7.Controllers;
using GymManagmentSystem7.DB;
using GymManagmentSystem7.UserControls;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;


namespace GymManagmentSystem7
{
    public partial class MainDashboard : Form
    {
        private bool passwordVisible = false;
        private int _loggedInMemberId = -1;
        private int _loggedInTrainerId = -1;


        public MainDashboard()
        {
            InitializeComponent();
            txtboxPassword.UseSystemPasswordChar = true;
            dgvMembers.CellFormatting += dgvMembers_CellFormatting;
            dgvMembers.CellContentClick += dgvMembers_CellContentClick;
            dgvTrainers.CellContentClick += dgvTrainers_CellContentClick;
            dgvTrainers.CellFormatting += dgvTrainers_CellFormatting;
            dgvPayments.CellContentClick += dgvPayments_CellContentClick;
            dgvPayments.CellFormatting += dgvPayments_CellFormatting;
            dgvPlans.CellContentClick += dgvPlans_CellContentClick;
            dgvPlans.CellFormatting += dgvPlans_CellFormatting;
            dgvAttendance.CellContentClick += dgvAttendance_CellContentClick;
            dgvAttendance.CellFormatting += dgvAttendance_CellFormatting;



        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.");
                txtboxUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                txtboxPassword.Focus();
                return;
            }

            var controller = new AccountController();
            var (account, message) = controller.Login(username, password);

            if (account == null)
            {
                ShowInvalid();
                return;
            }

            tabcontrolMain.TabPages.Clear();

            switch (account.Role)
            {
                case AccountRole.Admin:

                    if (account.Username.ToLower() == "superadmin")
                    {
                        tabcontrolMain.TabPages.AddRange(new TabPage[] {
                    Registrationtab, Trainertab, Paymenttab,
                    MyPlantab, Mypaymenttab,
                    Msplantab, MsAttendancetab
                });
                    }
                    else
                    {

                        tabcontrolMain.TabPages.AddRange(new TabPage[] {
                    Registrationtab, Trainertab,
                    Msplantab, MsAttendancetab
                });
                    }
                    break;

                case AccountRole.Cashier:
                    tabcontrolMain.TabPages.Add(Paymenttab);
                    break;

                case AccountRole.Trainer:
                    int trainerId = GetTrainerIdFromAccount(account.AccountId);
                    _loggedInTrainerId = trainerId;
                    tabcontrolMain.TabPages.AddRange(new TabPage[] {
                Msplantab, MsAttendancetab
            });
                    break;

                case AccountRole.Member:
                    tabcontrolMain.TabPages.AddRange(new TabPage[] {
                MyPlantab, Mypaymenttab


            });
                    int memberId = GetMemberIdFromAccount(account.AccountId);  // Add this helper method
                    LoadMyPaymentsToGrid(memberId);
                    LoadMyPlansToGrid(memberId);
                    _loggedInMemberId = memberId; // store it for later refresh


                    break;

            }

            // ✅ Automatically load members if user is Admin, Cashier, or Trainer
            if (account.Role == AccountRole.Admin || account.Role == AccountRole.Cashier || account.Role == AccountRole.Trainer)
            {
                LoadMembersToGrid(); // <--- Make sure this method is defined!
            }


            Loginpanel.Visible = false;
            tabcontrolMain.Visible = true;
            Logoutbtn.Visible = true;
        }

        private void ShowInvalid()
        {
            this.Focus();
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // prevents the beep sound
                txtboxPassword.Focus();
            }
        }

        private void txtboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtboxUsername.Focus();
            }
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

            Loginpanel.Visible = true;
            Loginpanel.BringToFront();


            tabcontrolMain.Visible = false;

            Logoutbtn.Visible = false;


            // ✅ Add this line to load trainers on startup
            LoadTrainersToGrid();
            LoadPaymentsToGrid();
            LoadPlansToGrid();
            LoadMsAttendance();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {

            // Dispose all user controls dynamically added on top
            var dynamicControls = Controls.OfType<UserControl>().ToList();
            foreach (var ctrl in dynamicControls)
            {
                ctrl.Dispose();
            }

            // Hide all tabs
            tabcontrolMain.TabPages.Clear();
            tabcontrolMain.Visible = false;

            // Show login panel again
            Loginpanel.Visible = true;
            Loginpanel.BringToFront();

            Logoutbtn.Visible = false;

            // Optional: Clear login inputs
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxUsername.Focus();
        }

        private void txtboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Registrationtab_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var addMem = new uc_AddMember(this);
            Controls.Add(addMem);
            addMem.BringToFront();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                var testCon = new DBConnection()._Connect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Success");
        }

        private void uc_AddMember1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addPay = new uc_AddPayment(this);
            Controls.Add(addPay);
            addPay.BringToFront();
        }

        private void btnMsAddAttend_Click(object sender, EventArgs e)
        {
            var addAttend = new uc_AddmemAttend(this, _loggedInTrainerId);
            Controls.Add(addAttend);
            addAttend.BringToFront();
        }

        private void uc_AddmemAttend1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            var addTrainer = new us_AddTrainer(this);
            Controls.Add(addTrainer);
            addTrainer.BringToFront();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var addAccount = new uc_AddAccount();
            Controls.Add(addAccount);
            addAccount.BringToFront();
        }

        private void btnMsAdd1_Click(object sender, EventArgs e)
        {
            var addPlan = new uc_AddMsPlan(this, _loggedInTrainerId);
            Controls.Add(addPlan);
            addPlan.BringToFront();
        }


        public void LoadMembersToGrid()
        {
            var controller = new MemberController();
            var members = controller.GetAllMembers(); // Uses SqlDataReader and DTO

            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.DataSource = members;

            // Optional styling: Set column headers only if needed
            // dgvMembers.Columns["Status"].HeaderText = "Status";

            foreach (DataGridViewRow row in dgvMembers.Rows)
            {
                if (row.Cells["Status"].Value == null || row.Cells["Mode"] == null)
                    continue;

                string status = row.Cells["Status"].Value.ToString();
                var modeCell = row.Cells["Mode"] as DataGridViewButtonCell;

                if (status == "A")
                {
                    modeCell.Value = "Deactivate";
                    modeCell.Style.BackColor = Color.Red;
                    modeCell.Style.ForeColor = Color.White;
                    modeCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "D")
                {
                    modeCell.Value = "Activate";
                    modeCell.Style.BackColor = Color.LightGreen;
                    modeCell.Style.ForeColor = Color.Black;
                    modeCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembers.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "A")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "D")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvMembers.Columns[e.ColumnIndex].Name == "Edit")
            {
                int id = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells["MemberId"].Value);
                string fName = dgvMembers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                string lName = dgvMembers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                string gender = dgvMembers.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                string age = dgvMembers.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                string type = dgvMembers.Rows[e.RowIndex].Cells["MembershipType"].Value.ToString();

                var editControl = new uc_AddMember(this);
                editControl.LoadMemberForEdit(id, fName, lName, gender, age, type);
                Controls.Add(editControl);
                editControl.BringToFront();
            }

            if (dgvMembers.Columns[e.ColumnIndex].Name == "Mode")
            {
                int accountId = Convert.ToInt32(dgvMembers.Rows[e.RowIndex].Cells["Accountdi"].Value);
                string currentStatus = dgvMembers.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                // ✅ Step 1: Ask for confirmation
                string action = currentStatus == "A" ? "deactivate" : "activate";
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to {action} this member?",
                    "Confirm Action",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    var controller = new AccountController();

                    // ✅ Step 2: Try to change the status
                    if (controller.ToggleAccountStatus(accountId))
                    {
                        LoadMembersToGrid(); // Refresh UI

                        // ✅ Step 3: Show success message
                        string successMsg = currentStatus == "A"
                            ? "Member has been deactivated successfully."
                            : "Member has been activated successfully.";

                        MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // ✅ Optional: Handle failure
                        MessageBox.Show("Failed to update member status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void Btndelete48_Click(object sender, EventArgs e)
        {

            var selectedMemberIds = new List<int>();
            var selectedAccountIds = new List<int>();

            foreach (DataGridViewRow row in dgvMembers.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Delete"].Value) == true)
                {
                    int memberId = Convert.ToInt32(row.Cells["MemberId"].Value);
                    int accountId = Convert.ToInt32(row.Cells["Accountdi"].Value);

                    selectedMemberIds.Add(memberId);
                    selectedAccountIds.Add(accountId);
                }
            }

            if (selectedMemberIds.Count == 0)
            {
                MessageBox.Show("No rows selected.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete the selected members and their accounts?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (var conn = new DBConnection()._Connect)
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    for (int i = 0; i < selectedMemberIds.Count; i++)
                    {
                        // Delete from Member table
                        string deleteMemberSql = "DELETE FROM Member WHERE MemberId = @MemberId";
                        SqlCommand memberCmd = new SqlCommand(deleteMemberSql, conn, trans);
                        memberCmd.Parameters.AddWithValue("@MemberId", selectedMemberIds[i]);
                        memberCmd.ExecuteNonQuery();

                        // Delete from Account table
                        string deleteAccountSql = "DELETE FROM Account WHERE AccountId = @AccountId";
                        SqlCommand accountCmd = new SqlCommand(deleteAccountSql, conn, trans);
                        accountCmd.Parameters.AddWithValue("@AccountId", selectedAccountIds[i]);
                        accountCmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Selected members and their accounts deleted successfully.");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error during deletion: " + ex.Message);
                }
            }

            LoadMembersToGrid(); // Refresh the grid
        }

        private void btnrefreshMplan_Click(object sender, EventArgs e)
        {
            LoadMyPlansToGrid(_loggedInMemberId);

        }
        private void btnrefreshMyPay_Click(object sender, EventArgs e)
        {
            LoadMyPaymentsToGrid(_loggedInMemberId);
        }

        private void btnrefreshmypro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtboxPassword.UseSystemPasswordChar = !passwordVisible;
        }

        private void btnRefreshMembers_Click(object sender, EventArgs e)
        {
            LoadMembersToGrid(); // ✅ Manual refresh when button is clicked
        }
        public void LoadTrainersToGrid()
        {
            var controller = new TrainerController();
            var trainers = controller.GetAllTrainers();

            dgvTrainers.AutoGenerateColumns = false;
            dgvTrainers.DataSource = trainers;

            // ✅ Optional formatting
            foreach (DataGridViewRow row in dgvTrainers.Rows)
            {
                if (row.Cells["StatusTrainer"].Value == null || row.Cells["ModeTrainer"] == null)
                    continue;

                string status = row.Cells["StatusTrainer"].Value.ToString();
                var modeCell = row.Cells["ModeTrainer"] as DataGridViewButtonCell;

                if (status == "A")
                {
                    modeCell.Value = "Deactivate";
                    modeCell.Style.BackColor = Color.Red;
                    modeCell.Style.ForeColor = Color.White;
                }
                else if (status == "D")
                {
                    modeCell.Value = "Activate";
                    modeCell.Style.BackColor = Color.LightGreen;
                    modeCell.Style.ForeColor = Color.Black;
                }
            }
        }
        
        private void deletetrainbtn23_Click(object sender, EventArgs e)
        {

            var selectedIds = new List<int>();
            var selectedAccountIds = new List<int>();

            foreach (DataGridViewRow row in dgvTrainers.Rows)
            {
                if (Convert.ToBoolean(row.Cells["DeleteTrainer"].Value) == true)
                {
                    selectedIds.Add(Convert.ToInt32(row.Cells["TrainerId"].Value));
                    selectedAccountIds.Add(Convert.ToInt32(row.Cells["Accountme"].Value));
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete selected trainer(s)?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var conn = new DBConnection()._Connect)
                {
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        for (int i = 0; i < selectedIds.Count; i++)
                        {
                            string deleteTrainer = "DELETE FROM Trainer WHERE TrainerId = @id";
                            SqlCommand cmdTrainer = new SqlCommand(deleteTrainer, conn, trans);
                            cmdTrainer.Parameters.AddWithValue("@id", selectedIds[i]);
                            cmdTrainer.ExecuteNonQuery();

                            string deleteAccount = "DELETE FROM Account WHERE AccountId = @accId";
                            SqlCommand cmdAcc = new SqlCommand(deleteAccount, conn, trans);
                            cmdAcc.Parameters.AddWithValue("@accId", selectedAccountIds[i]);
                            cmdAcc.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Trainer(s) deleted successfully.");
                        LoadTrainersToGrid();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                LoadTrainersToGrid();
            }
        }
        private void dgvTrainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTrainers.Columns[e.ColumnIndex].Name == "Edittrainer")
            {
                int id = Convert.ToInt32(dgvTrainers.Rows[e.RowIndex].Cells["TrainerId"].Value);
                string fName = dgvTrainers.Rows[e.RowIndex].Cells["Tfirstname"].Value.ToString();
                string lName = dgvTrainers.Rows[e.RowIndex].Cells["Tlastname"].Value.ToString();
                string specialization = dgvTrainers.Rows[e.RowIndex].Cells["Tspecialization"].Value.ToString();

                var editControl = new us_AddTrainer(this);  // Pass MainDashboard reference
                editControl.LoadTrainerForEdit(id, fName, lName, specialization);
                Controls.Add(editControl);
                editControl.BringToFront();
            }

            if (dgvTrainers.Columns[e.ColumnIndex].Name == "ModeTrainer")
            {
                int accountId = Convert.ToInt32(dgvTrainers.Rows[e.RowIndex].Cells["Accountme"].Value);
                string currentStatus = dgvTrainers.Rows[e.RowIndex].Cells["StatusTrainer"].Value.ToString();

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to {(currentStatus == "A" ? "deactivate" : "activate")} this trainer?",
                    "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var controller = new AccountController();
                    if (controller.ToggleAccountStatus(accountId))
                    {
                        LoadTrainersToGrid();
                        MessageBox.Show("Status updated successfully.");
                    }
                }
            }

        }
        private void dgvTrainers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTrainers.Columns[e.ColumnIndex].Name == "StatusTrainer" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "A")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "D")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void refreshtrain2433_Click(object sender, EventArgs e)
        {
            LoadTrainersToGrid();
        }
        public void LoadPaymentsToGrid()
        {
            var controller = new PaymentController();
            var list = controller.GetAllPayments();

            dgvPayments.AutoGenerateColumns = false;
            dgvPayments.DataSource = list;

            // ✅ Optional styling for Status
            foreach (DataGridViewRow row in dgvPayments.Rows)
            {
                if (row.Cells["Statusmemb"].Value == null) continue;

                string status = row.Cells["Statusmemb"].Value.ToString();
                if (status == "A")
                {
                    row.Cells["Statusmemb"].Style.ForeColor = Color.Green;
                    row.Cells["Statusmemb"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "D")
                {
                    row.Cells["Statusmemb"].Style.ForeColor = Color.Red;
                    row.Cells["Statusmemb"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }


        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Check if clicked column is the Edit button
            if (dgvPayments.Columns[e.ColumnIndex].Name == "Editpayment")
            {
                int paymentId = Convert.ToInt32(dgvPayments.Rows[e.RowIndex].Cells["Paymentid"].Value);
                int memberId = Convert.ToInt32(dgvPayments.Rows[e.RowIndex].Cells["Memberdd"].Value);
                decimal amount = Convert.ToDecimal(dgvPayments.Rows[e.RowIndex].Cells["Amount"].Value);
                DateTime paymentDate = Convert.ToDateTime(dgvPayments.Rows[e.RowIndex].Cells["PaymentDate"].Value);

                var editControl = new uc_AddPayment(this);
                Controls.Add(editControl);
                editControl.BringToFront();
                editControl.LoadPaymentForEdit(paymentId, memberId, amount, paymentDate);
            }
        }

        private void deletepaybtn21_Click(object sender, EventArgs e)
        {
            var selectedIds = new List<int>();

            foreach (DataGridViewRow row in dgvPayments.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Deletepayment"].Value) == true)
                {
                    int paymentId = Convert.ToInt32(row.Cells["Paymentid"].Value);
                    selectedIds.Add(paymentId);
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected payments?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var conn = new DBConnection()._Connect)
                {
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        foreach (int paymentId in selectedIds)
                        {
                            string deleteSql = "DELETE FROM Payment WHERE PaymentId = @id";
                            SqlCommand cmd = new SqlCommand(deleteSql, conn, trans);
                            cmd.Parameters.AddWithValue("@id", paymentId);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Selected payments deleted successfully.");
                        LoadPaymentsToGrid(); // Refresh grid
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Error during deletion: " + ex.Message);
                    }
                }
            }
        }
        private void dgvPayments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPayments.Columns[e.ColumnIndex].Name == "Statusmemb" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "A")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "D")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
        private void btnRefreshPayments_Click_1(object sender, EventArgs e)
        {
            LoadPaymentsToGrid();
        }
        public void LoadMyPaymentsToGrid(int memberId)
        {
            var controller = new PaymentController();
            var payments = controller.GetPaymentsByMember(memberId);

            dgvMyPayment.AutoGenerateColumns = false;
            dgvMyPayment.DataSource = payments;
        }
        private int GetMemberIdFromAccount(int accountId)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = "SELECT MemberId FROM Member WHERE AccountId = @AccountId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("No Member linked to this Account.");
                }
            }
        }
        public void LoadPlansToGrid()
        {
            var controller = new TrainerController();
            var list = controller.GetAllPlans(); // 🎯 This now uses the controller

            dgvPlans.AutoGenerateColumns = false;
            dgvPlans.DataSource = list;

            // ✅ Status styling
            foreach (DataGridViewRow row in dgvPlans.Rows)
            {
                var statusCell = row.Cells["Statusmembers"];
                if (statusCell?.Value != null)
                {
                    string status = statusCell.Value.ToString();
                    if (status == "A")
                    {
                        statusCell.Style.ForeColor = Color.Green;
                        statusCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                    else if (status == "D")
                    {
                        statusCell.Style.ForeColor = Color.Red;
                        statusCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                }
            }
        }


        private void dgvPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // ✅ Handle Edit button
            if (dgvPlans.Columns[e.ColumnIndex].Name == "Editplan")
            {
                int planId = Convert.ToInt32(dgvPlans.Rows[e.RowIndex].Cells["Planid"].Value);
                string duration = dgvPlans.Rows[e.RowIndex].Cells["Durationgrid1"].Value.ToString();
                DateTime assignedDate = Convert.ToDateTime(dgvPlans.Rows[e.RowIndex].Cells["Assignedgrid1"].Value);

                // ❗ You must store MemberId in a hidden column for this to work!
                int memberId = Convert.ToInt32(dgvPlans.Rows[e.RowIndex].Cells["Memberdi"].Value); // Make sure you include it

                var editControl = new uc_AddMsPlan(this, _loggedInTrainerId);
                editControl.LoadPlanForEdit(planId, memberId, duration, assignedDate);
                Controls.Add(editControl);
                editControl.BringToFront();
            }
        }

        private int GetTrainerIdFromAccount(int accountId)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = "SELECT TrainerId FROM Trainer WHERE AccountId = @accId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@accId", accountId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
        private void dgvPlans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPlans.Columns[e.ColumnIndex].Name == "Statusmembers" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "A")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
                else if (status == "D")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void btnDeletePlan_Click(object sender, EventArgs e)
        {
            var selectedIds = new List<int>();

            foreach (DataGridViewRow row in dgvPlans.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Deleteplan"].Value) == true)
                {
                    int planId = Convert.ToInt32(row.Cells["Planid"].Value);
                    selectedIds.Add(planId);
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete selected workout plans?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (var conn = new DBConnection()._Connect)
                {
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        foreach (int id in selectedIds)
                        {
                            string deleteSql = "DELETE FROM WorkoutPlan WHERE PlanId = @id";
                            SqlCommand cmd = new SqlCommand(deleteSql, conn, trans);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Workout plans deleted.");
                        LoadPlansToGrid();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnRefreshPlans_Click(object sender, EventArgs e)
        {
            LoadPlansToGrid();
        }
        public void LoadMyPlansToGrid(int memberId)
        {
            var controller = new TrainerController();
            var plans = controller.GetPlansByMember(memberId);

            dgvMPlan.AutoGenerateColumns = false;
            dgvMPlan.DataSource = plans;
        }
        public void LoadMsAttendance()
        {
            var controller = new TrainerController();
            var data = controller.GetAllAttendance(); // ✅ Loads all attendance records

            dgvAttendance.AutoGenerateColumns = false;
            dgvAttendance.DataSource = data;

            // Set data property names to match DTO
            dgvAttendance.Columns["MsName13"].DataPropertyName = "MemberFullName";
            dgvAttendance.Columns["Date13"].DataPropertyName = "Date";
            dgvAttendance.Columns["Status13"].DataPropertyName = "Status";

            // Optional: apply coloring
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (row.Cells["Status13"]?.Value?.ToString() == "P")
                {
                    row.Cells["Status13"].Style.ForeColor = Color.Green;
                    row.Cells["Status13"].Value = "Present";
                }
                else if (row.Cells["Status13"]?.Value?.ToString() == "A")
                {
                    row.Cells["Status13"].Style.ForeColor = Color.Red;
                    row.Cells["Status13"].Value = "Absent";
                }
            }
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            var selectedIds = new List<int>();

            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Deleteattend"].Value) == true)
                {
                    int attendanceId = Convert.ToInt32(row.Cells["AttendanceId"].Value);
                    selectedIds.Add(attendanceId);
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete selected records?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (var conn = new DBConnection()._Connect)
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    foreach (int id in selectedIds)
                    {
                        string sql = "DELETE FROM Attendance WHERE AttendanceId = @id";
                        SqlCommand cmd = new SqlCommand(sql, conn, trans);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Selected attendance records deleted.");
                    LoadMsAttendance(); // Refresh after deletion
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error during delete: " + ex.Message);
                }
            }
        }
        private void dgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAttendance.Columns[e.ColumnIndex].Name == "Status13" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "P")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "Present";
                }
                else if (status == "A")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.Value = "Absent";
                }
            }
        }
      
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvAttendance.Columns[e.ColumnIndex].Name == "Editattend")
            {
                int attendanceId = Convert.ToInt32(dgvAttendance.Rows[e.RowIndex].Cells["AttendanceId"].Value);
                int memberId = Convert.ToInt32(dgvAttendance.Rows[e.RowIndex].Cells["MsMemberId"].Value);
                DateTime date = Convert.ToDateTime(dgvAttendance.Rows[e.RowIndex].Cells["Date13"].Value);
                string status = dgvAttendance.Rows[e.RowIndex].Cells["Status13"].Value.ToString();

                var edit = new uc_AddmemAttend(this, _loggedInTrainerId);
                Controls.Add(edit);
                edit.BringToFront();
                edit.LoadAttendanceForEdit(attendanceId, memberId, date, status);
            }
        }

        private void btnRefreshAttendance_Click(object sender, EventArgs e)
        {
            LoadMsAttendance();
        }
    }
}






