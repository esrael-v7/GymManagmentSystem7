using GymManagementSystem7.Models;
using GymManagmentSystem7.Controller;
using GymManagmentSystem7.DB;
using GymManagmentSystem7.UserControls;
using Microsoft.Data.SqlClient;


namespace GymManagmentSystem7
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
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
                    // ✅ If this is the Super Admin, show all tabs
                    if (account.Username.ToLower() == "superadmin")
                    {
                        tabcontrolMain.TabPages.AddRange(new TabPage[] {
                    Registrationtab, Trainertab, Paymenttab,
                    MyPlantab, Mypaymenttab, MyProgresstab,
                    Msplantab, MsProgresstab, MsAttendancetab
                });
                    }
                    else
                    {
                        // Normal Admin: show only admin-specific tabs
                        tabcontrolMain.TabPages.AddRange(new TabPage[] {
                    Registrationtab, Trainertab,
                    Msplantab, MsProgresstab, MsAttendancetab
                });
                    }
                    break;

                case AccountRole.Cashier:
                    tabcontrolMain.TabPages.Add(Paymenttab);
                    break;

                case AccountRole.Trainer:
                    tabcontrolMain.TabPages.AddRange(new TabPage[] {
                Msplantab, MsProgresstab, MsAttendancetab
            });
                    break;

                case AccountRole.Member:
                    tabcontrolMain.TabPages.AddRange(new TabPage[] {
                MyPlantab, Mypaymenttab, MyProgresstab
            });
                    break;
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
                e.Handled = true; // prevents the beep sound
                txtboxUsername.Focus();
            }
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // Show login panel
            Loginpanel.Visible = true;
            Loginpanel.BringToFront();

            // Hide the tab control
            tabcontrolMain.Visible = false;

            Logoutbtn.Visible = false;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            // Hide all tabs
            tabcontrolMain.TabPages.Clear();
            tabcontrolMain.Visible = false;

            // Show the login panel again
            Loginpanel.Visible = true;
            Loginpanel.BringToFront();


            Logoutbtn.Visible = false;

            // Optional: Clear login fields
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxUsername.Focus();
        }

        private void txtboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick(); // Triggers the login click
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
            var addMem = new uc_AddMember();
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
            var addPay = new ucAddPayment();
            Controls.Add(addPay);
            addPay.BringToFront();
        }

        private void btnMsView1_Click(object sender, EventArgs e)
        {
            var viewPlan = new uc_viewMsPlan();
            Controls.Add(viewPlan);
            viewPlan.BringToFront();
        }

        private void btnMsView_Click(object sender, EventArgs e)
        {
            var viewProgress = new uc_ViewMsProgress();
            Controls.Add(viewProgress);
            viewProgress.BringToFront();
        }

        private void btnMsAddAttend_Click(object sender, EventArgs e)
        {
            var addAttend = new uc_AddmemAttend();
            Controls.Add(addAttend);
            addAttend.BringToFront();
        }

        private void uc_AddmemAttend1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            var addTrainer = new us_AddTrainer();
            Controls.Add(addTrainer);
            addTrainer.BringToFront();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var addAccount = new uc_AddAccount();
            Controls.Add(addAccount);
            addAccount.BringToFront();
        }
    }
}



