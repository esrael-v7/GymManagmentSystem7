using System.Data.SqlClient;
namespace GymManagmentSystem7

{
    partial class MainDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            Loginpanel = new Panel();
            pictureBox3 = new PictureBox();
            Title = new Label();
            txtboxUsername = new TextBox();
            txtboxPassword = new TextBox();
            buttonLogin = new Button();
            Passwordlabel = new Label();
            Usernamelabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabcontrolMain = new TabControl();
            Registrationtab = new TabPage();
            btnAddAccount = new Button();
            btnTestConnection = new Button();
            dataGridView2 = new DataGridView();
            MemberID = new DataGridViewTextBoxColumn();
            FNameColumn = new DataGridViewTextBoxColumn();
            Lname1 = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            MemberShipType1 = new DataGridViewTextBoxColumn();
            btnAddMember = new Button();
            label6 = new Label();
            Trainertab = new TabPage();
            dataGridView3 = new DataGridView();
            Tname = new DataGridViewTextBoxColumn();
            txtspecality = new DataGridViewTextBoxColumn();
            txtPhoneTrainer = new DataGridViewTextBoxColumn();
            dtpHireDate = new DataGridViewTextBoxColumn();
            btnAddTrainer = new Button();
            label7 = new Label();
            Paymenttab = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Pmember = new DataGridViewTextBoxColumn();
            PDate = new DataGridViewTextBoxColumn();
            PAmount = new DataGridViewTextBoxColumn();
            PFor = new DataGridViewTextBoxColumn();
            button3 = new Button();
            label5 = new Label();
            MyPlantab = new TabPage();
            btnrefreshMplan = new Button();
            dataGridView4 = new DataGridView();
            PlanName1 = new DataGridViewTextBoxColumn();
            Duration1 = new DataGridViewTextBoxColumn();
            Trainer = new DataGridViewTextBoxColumn();
            Date1 = new DataGridViewTextBoxColumn();
            Assigned1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Mypaymenttab = new TabPage();
            btnrefreshMyPay = new Button();
            dataGridView5 = new DataGridView();
            Date2 = new DataGridViewTextBoxColumn();
            Amount2 = new DataGridViewTextBoxColumn();
            Description2 = new DataGridViewTextBoxColumn();
            MYPaymentlab = new Label();
            MyProgresstab = new TabPage();
            btnrefreshmypro = new Button();
            dataGridView6 = new DataGridView();
            Date3 = new DataGridViewTextBoxColumn();
            Weight3 = new DataGridViewTextBoxColumn();
            BodyFat1 = new DataGridViewTextBoxColumn();
            Notes1 = new DataGridViewTextBoxColumn();
            MyprogressLab = new Label();
            Msplantab = new TabPage();
            Msplanduratilab = new Label();
            btnMsView1 = new Button();
            btnMsDelete1 = new Button();
            btnMsUpdate1 = new Button();
            btnMsAdd1 = new Button();
            textBox5 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            MsAssignlab = new Label();
            MsDate1lab = new Label();
            MsMemelab = new Label();
            Msplanlab = new Label();
            MsProgresstab = new TabPage();
            btnMsView = new Button();
            btnMsDelete = new Button();
            btnMsUpdate = new Button();
            btnMsAdd = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            Msnotelab = new Label();
            Msweightlab = new Label();
            Msbodylab = new Label();
            Msdatelab = new Label();
            Msnamelab = new Label();
            MsAttendancetab = new TabPage();
            btnMSUpdateAttend = new Button();
            btnMsAddAttend = new Button();
            MsAttendlab1 = new Label();
            dataGridView7 = new DataGridView();
            MsName13 = new DataGridViewTextBoxColumn();
            Date13 = new DataGridViewTextBoxColumn();
            Status13 = new DataGridViewTextBoxColumn();
            Logoutbtn = new Button();
            Loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabcontrolMain.SuspendLayout();
            Registrationtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Trainertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Paymenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            MyPlantab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            Mypaymenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            MyProgresstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            Msplantab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            MsProgresstab.SuspendLayout();
            MsAttendancetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // Loginpanel
            // 
            Loginpanel.Controls.Add(pictureBox3);
            Loginpanel.Controls.Add(Title);
            Loginpanel.Controls.Add(txtboxUsername);
            Loginpanel.Controls.Add(txtboxPassword);
            Loginpanel.Controls.Add(buttonLogin);
            Loginpanel.Controls.Add(Passwordlabel);
            Loginpanel.Controls.Add(Usernamelabel);
            Loginpanel.Controls.Add(pictureBox1);
            Loginpanel.Controls.Add(pictureBox2);
            Loginpanel.Dock = DockStyle.Fill;
            Loginpanel.Location = new Point(0, 0);
            Loginpanel.Name = "Loginpanel";
            Loginpanel.Size = new Size(933, 476);
            Loginpanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(638, 242);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 38);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Crimson;
            Title.Location = new Point(346, 42);
            Title.Name = "Title";
            Title.Size = new Size(238, 37);
            Title.TabIndex = 7;
            Title.Text = "FITNESS CENTER";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(446, 155);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(225, 38);
            txtboxUsername.TabIndex = 6;
            txtboxUsername.UseSystemPasswordChar = true;
            txtboxUsername.KeyPress += txtboxUsername_KeyPress;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPassword.Location = new Point(446, 242);
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Size = new Size(225, 38);
            txtboxPassword.TabIndex = 4;
            txtboxPassword.UseSystemPasswordChar = true;
            txtboxPassword.KeyDown += txtboxPassword_KeyDown;
            txtboxPassword.KeyPress += txtboxPassword_KeyPress;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Crimson;
            buttonLogin.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(376, 333);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(135, 59);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordlabel.ForeColor = Color.FromArgb(0, 0, 192);
            Passwordlabel.Location = new Point(285, 247);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(130, 27);
            Passwordlabel.TabIndex = 1;
            Passwordlabel.Text = "Password :";
            // 
            // Usernamelabel
            // 
            Usernamelabel.AutoSize = true;
            Usernamelabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernamelabel.ForeColor = Color.FromArgb(0, 0, 192);
            Usernamelabel.Location = new Point(285, 166);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(138, 27);
            Usernamelabel.TabIndex = 0;
            Usernamelabel.Text = "Username :";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(933, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // tabcontrolMain
            // 
            tabcontrolMain.Controls.Add(Registrationtab);
            tabcontrolMain.Controls.Add(Trainertab);
            tabcontrolMain.Controls.Add(Paymenttab);
            tabcontrolMain.Controls.Add(MyPlantab);
            tabcontrolMain.Controls.Add(Mypaymenttab);
            tabcontrolMain.Controls.Add(MyProgresstab);
            tabcontrolMain.Controls.Add(Msplantab);
            tabcontrolMain.Controls.Add(MsProgresstab);
            tabcontrolMain.Controls.Add(MsAttendancetab);
            tabcontrolMain.Dock = DockStyle.Fill;
            tabcontrolMain.Location = new Point(0, 0);
            tabcontrolMain.Name = "tabcontrolMain";
            tabcontrolMain.SelectedIndex = 0;
            tabcontrolMain.Size = new Size(933, 476);
            tabcontrolMain.TabIndex = 6;
            // 
            // Registrationtab
            // 
            Registrationtab.Controls.Add(btnAddAccount);
            Registrationtab.Controls.Add(btnTestConnection);
            Registrationtab.Controls.Add(dataGridView2);
            Registrationtab.Controls.Add(btnAddMember);
            Registrationtab.Controls.Add(label6);
            Registrationtab.Location = new Point(4, 29);
            Registrationtab.Name = "Registrationtab";
            Registrationtab.Padding = new Padding(3);
            Registrationtab.Size = new Size(925, 443);
            Registrationtab.TabIndex = 0;
            Registrationtab.Text = "MemRegistration";
            Registrationtab.UseVisualStyleBackColor = true;
            Registrationtab.Click += Registrationtab_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.FromArgb(0, 192, 0);
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.Location = new Point(581, 98);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(126, 47);
            btnAddAccount.TabIndex = 4;
            btnAddAccount.Text = "AddAccount";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.FromArgb(0, 0, 192);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(360, 98);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(147, 47);
            btnTestConnection.TabIndex = 3;
            btnTestConnection.Text = "Test-Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { MemberID, FNameColumn, Lname1, Age, Gender, MemberShipType1 });
            dataGridView2.Location = new Point(1, 167);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(926, 271);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // MemberID
            // 
            MemberID.HeaderText = "M-ID";
            MemberID.MinimumWidth = 6;
            MemberID.Name = "MemberID";
            MemberID.Width = 125;
            // 
            // FNameColumn
            // 
            FNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FNameColumn.HeaderText = "F-Name";
            FNameColumn.MinimumWidth = 6;
            FNameColumn.Name = "FNameColumn";
            // 
            // Lname1
            // 
            Lname1.HeaderText = "L-Name";
            Lname1.MinimumWidth = 6;
            Lname1.Name = "Lname1";
            Lname1.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // MemberShipType1
            // 
            MemberShipType1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberShipType1.HeaderText = "MemberShip-Type";
            MemberShipType1.MinimumWidth = 6;
            MemberShipType1.Name = "MemberShipType1";
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(0, 192, 0);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(164, 98);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(122, 47);
            btnAddMember.TabIndex = 1;
            btnAddMember.Text = "AddMember";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(253, 13);
            label6.Name = "label6";
            label6.Size = new Size(327, 37);
            label6.TabIndex = 0;
            label6.Text = "Member Registration ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // Trainertab
            // 
            Trainertab.Controls.Add(dataGridView3);
            Trainertab.Controls.Add(btnAddTrainer);
            Trainertab.Controls.Add(label7);
            Trainertab.Location = new Point(4, 29);
            Trainertab.Name = "Trainertab";
            Trainertab.Padding = new Padding(3);
            Trainertab.Size = new Size(925, 443);
            Trainertab.TabIndex = 1;
            Trainertab.Text = "TrainerManagement";
            Trainertab.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Tname, txtspecality, txtPhoneTrainer, dtpHireDate });
            dataGridView3.Location = new Point(8, 170);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(914, 303);
            dataGridView3.TabIndex = 2;
            // 
            // Tname
            // 
            Tname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tname.HeaderText = "Trainer-Name";
            Tname.MinimumWidth = 6;
            Tname.Name = "Tname";
            // 
            // txtspecality
            // 
            txtspecality.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtspecality.HeaderText = "Speciality";
            txtspecality.MinimumWidth = 6;
            txtspecality.Name = "txtspecality";
            // 
            // txtPhoneTrainer
            // 
            txtPhoneTrainer.HeaderText = "T-Phone";
            txtPhoneTrainer.MinimumWidth = 6;
            txtPhoneTrainer.Name = "txtPhoneTrainer";
            txtPhoneTrainer.Width = 125;
            // 
            // dtpHireDate
            // 
            dtpHireDate.HeaderText = "Hire-Date";
            dtpHireDate.MinimumWidth = 6;
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Width = 125;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.BackColor = Color.Blue;
            btnAddTrainer.ForeColor = Color.White;
            btnAddTrainer.Location = new Point(372, 93);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(116, 41);
            btnAddTrainer.TabIndex = 1;
            btnAddTrainer.Text = "AddTrainer";
            btnAddTrainer.UseVisualStyleBackColor = false;
            btnAddTrainer.Click += btnAddTrainer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Green;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(257, 23);
            label7.Name = "label7";
            label7.Size = new Size(323, 37);
            label7.TabIndex = 0;
            label7.Text = "Trainer-Management";
            // 
            // Paymenttab
            // 
            Paymenttab.Controls.Add(button1);
            Paymenttab.Controls.Add(dataGridView1);
            Paymenttab.Controls.Add(button3);
            Paymenttab.Controls.Add(label5);
            Paymenttab.Location = new Point(4, 29);
            Paymenttab.Name = "Paymenttab";
            Paymenttab.Padding = new Padding(3);
            Paymenttab.Size = new Size(925, 443);
            Paymenttab.TabIndex = 2;
            Paymenttab.Text = "Payment";
            Paymenttab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 192);
            button1.ForeColor = Color.White;
            button1.Location = new Point(272, 105);
            button1.Name = "button1";
            button1.Size = new Size(107, 42);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pmember, PDate, PAmount, PFor });
            dataGridView1.Location = new Point(3, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(919, 306);
            dataGridView1.TabIndex = 13;
            // 
            // Pmember
            // 
            Pmember.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pmember.HeaderText = "P-Member";
            Pmember.MinimumWidth = 6;
            Pmember.Name = "Pmember";
            // 
            // PDate
            // 
            PDate.HeaderText = "P-Date";
            PDate.MinimumWidth = 6;
            PDate.Name = "PDate";
            PDate.Width = 125;
            // 
            // PAmount
            // 
            PAmount.HeaderText = "P-Amount";
            PAmount.MinimumWidth = 6;
            PAmount.Name = "PAmount";
            PAmount.Width = 125;
            // 
            // PFor
            // 
            PFor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PFor.HeaderText = "P-For";
            PFor.MinimumWidth = 6;
            PFor.Name = "PFor";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(522, 105);
            button3.Name = "button3";
            button3.Size = new Size(102, 42);
            button3.TabIndex = 12;
            button3.Text = "AddPayment";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Green;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(372, 31);
            label5.Name = "label5";
            label5.Size = new Size(147, 37);
            label5.TabIndex = 4;
            label5.Text = "Payment";
            // 
            // MyPlantab
            // 
            MyPlantab.Controls.Add(btnrefreshMplan);
            MyPlantab.Controls.Add(dataGridView4);
            MyPlantab.Controls.Add(label1);
            MyPlantab.Location = new Point(4, 29);
            MyPlantab.Name = "MyPlantab";
            MyPlantab.Padding = new Padding(3);
            MyPlantab.Size = new Size(925, 443);
            MyPlantab.TabIndex = 3;
            MyPlantab.Text = "MyPlan";
            MyPlantab.UseVisualStyleBackColor = true;
            // 
            // btnrefreshMplan
            // 
            btnrefreshMplan.BackColor = Color.Maroon;
            btnrefreshMplan.ForeColor = Color.White;
            btnrefreshMplan.Location = new Point(363, 93);
            btnrefreshMplan.Name = "btnrefreshMplan";
            btnrefreshMplan.Size = new Size(134, 41);
            btnrefreshMplan.TabIndex = 2;
            btnrefreshMplan.Text = "Refresh";
            btnrefreshMplan.UseVisualStyleBackColor = false;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { PlanName1, Duration1, Trainer, Date1, Assigned1 });
            dataGridView4.Location = new Point(8, 146);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(914, 302);
            dataGridView4.TabIndex = 1;
            // 
            // PlanName1
            // 
            PlanName1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PlanName1.HeaderText = "Plan-Name";
            PlanName1.MinimumWidth = 6;
            PlanName1.Name = "PlanName1";
            // 
            // Duration1
            // 
            Duration1.HeaderText = "Duration";
            Duration1.MinimumWidth = 6;
            Duration1.Name = "Duration1";
            Duration1.Width = 125;
            // 
            // Trainer
            // 
            Trainer.HeaderText = "Trainer";
            Trainer.MinimumWidth = 6;
            Trainer.Name = "Trainer";
            Trainer.Width = 125;
            // 
            // Date1
            // 
            Date1.HeaderText = "Date";
            Date1.MinimumWidth = 6;
            Date1.Name = "Date1";
            Date1.Width = 125;
            // 
            // Assigned1
            // 
            Assigned1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Assigned1.HeaderText = "Assigned";
            Assigned1.MinimumWidth = 6;
            Assigned1.Name = "Assigned1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 30);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "My Workout-Plan";
            // 
            // Mypaymenttab
            // 
            Mypaymenttab.Controls.Add(btnrefreshMyPay);
            Mypaymenttab.Controls.Add(dataGridView5);
            Mypaymenttab.Controls.Add(MYPaymentlab);
            Mypaymenttab.Location = new Point(4, 29);
            Mypaymenttab.Name = "Mypaymenttab";
            Mypaymenttab.Padding = new Padding(3);
            Mypaymenttab.Size = new Size(925, 443);
            Mypaymenttab.TabIndex = 4;
            Mypaymenttab.Text = "MyPayment";
            Mypaymenttab.UseVisualStyleBackColor = true;
            // 
            // btnrefreshMyPay
            // 
            btnrefreshMyPay.BackColor = Color.FromArgb(0, 0, 192);
            btnrefreshMyPay.ForeColor = Color.White;
            btnrefreshMyPay.Location = new Point(372, 118);
            btnrefreshMyPay.Name = "btnrefreshMyPay";
            btnrefreshMyPay.Size = new Size(135, 46);
            btnrefreshMyPay.TabIndex = 2;
            btnrefreshMyPay.Text = "Refresh";
            btnrefreshMyPay.UseVisualStyleBackColor = false;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { Date2, Amount2, Description2 });
            dataGridView5.Location = new Point(112, 200);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(714, 188);
            dataGridView5.TabIndex = 1;
            // 
            // Date2
            // 
            Date2.HeaderText = "P-Date";
            Date2.MinimumWidth = 6;
            Date2.Name = "Date2";
            Date2.Width = 125;
            // 
            // Amount2
            // 
            Amount2.HeaderText = "P-Amount";
            Amount2.MinimumWidth = 6;
            Amount2.Name = "Amount2";
            Amount2.Width = 125;
            // 
            // Description2
            // 
            Description2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description2.HeaderText = "Description";
            Description2.MinimumWidth = 6;
            Description2.Name = "Description2";
            // 
            // MYPaymentlab
            // 
            MYPaymentlab.AutoSize = true;
            MYPaymentlab.BackColor = Color.FromArgb(192, 0, 0);
            MYPaymentlab.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MYPaymentlab.ForeColor = Color.White;
            MYPaymentlab.Location = new Point(294, 50);
            MYPaymentlab.Name = "MYPaymentlab";
            MYPaymentlab.Size = new Size(304, 37);
            MYPaymentlab.TabIndex = 0;
            MYPaymentlab.Text = "My Payment History";
            // 
            // MyProgresstab
            // 
            MyProgresstab.Controls.Add(btnrefreshmypro);
            MyProgresstab.Controls.Add(dataGridView6);
            MyProgresstab.Controls.Add(MyprogressLab);
            MyProgresstab.Location = new Point(4, 29);
            MyProgresstab.Name = "MyProgresstab";
            MyProgresstab.Padding = new Padding(3);
            MyProgresstab.Size = new Size(925, 443);
            MyProgresstab.TabIndex = 5;
            MyProgresstab.Text = "MyProgress";
            MyProgresstab.UseVisualStyleBackColor = true;
            // 
            // btnrefreshmypro
            // 
            btnrefreshmypro.BackColor = Color.FromArgb(0, 192, 0);
            btnrefreshmypro.ForeColor = Color.White;
            btnrefreshmypro.Location = new Point(372, 114);
            btnrefreshmypro.Name = "btnrefreshmypro";
            btnrefreshmypro.Size = new Size(147, 50);
            btnrefreshmypro.TabIndex = 2;
            btnrefreshmypro.Text = "Refresh";
            btnrefreshmypro.UseVisualStyleBackColor = false;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Columns.AddRange(new DataGridViewColumn[] { Date3, Weight3, BodyFat1, Notes1 });
            dataGridView6.Location = new Point(118, 189);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(719, 188);
            dataGridView6.TabIndex = 1;
            // 
            // Date3
            // 
            Date3.HeaderText = "Pro-Date";
            Date3.MinimumWidth = 6;
            Date3.Name = "Date3";
            Date3.Width = 125;
            // 
            // Weight3
            // 
            Weight3.HeaderText = "Weight(kg)";
            Weight3.MinimumWidth = 6;
            Weight3.Name = "Weight3";
            Weight3.Width = 125;
            // 
            // BodyFat1
            // 
            BodyFat1.HeaderText = "BodyFat(%)";
            BodyFat1.MinimumWidth = 6;
            BodyFat1.Name = "BodyFat1";
            BodyFat1.Width = 125;
            // 
            // Notes1
            // 
            Notes1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes1.HeaderText = "Notes";
            Notes1.MinimumWidth = 6;
            Notes1.Name = "Notes1";
            // 
            // MyprogressLab
            // 
            MyprogressLab.AutoSize = true;
            MyprogressLab.BackColor = Color.FromArgb(0, 0, 192);
            MyprogressLab.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MyprogressLab.ForeColor = Color.White;
            MyprogressLab.Location = new Point(304, 50);
            MyprogressLab.Name = "MyprogressLab";
            MyprogressLab.Size = new Size(293, 37);
            MyprogressLab.TabIndex = 0;
            MyprogressLab.Text = "My Progress History";
            // 
            // Msplantab
            // 
            Msplantab.Controls.Add(Msplanduratilab);
            Msplantab.Controls.Add(btnMsView1);
            Msplantab.Controls.Add(btnMsDelete1);
            Msplantab.Controls.Add(btnMsUpdate1);
            Msplantab.Controls.Add(btnMsAdd1);
            Msplantab.Controls.Add(textBox5);
            Msplantab.Controls.Add(dateTimePicker2);
            Msplantab.Controls.Add(numericUpDown1);
            Msplantab.Controls.Add(comboBox2);
            Msplantab.Controls.Add(textBox4);
            Msplantab.Controls.Add(MsAssignlab);
            Msplantab.Controls.Add(MsDate1lab);
            Msplantab.Controls.Add(MsMemelab);
            Msplantab.Controls.Add(Msplanlab);
            Msplantab.Location = new Point(4, 29);
            Msplantab.Name = "Msplantab";
            Msplantab.Padding = new Padding(3);
            Msplantab.Size = new Size(925, 443);
            Msplantab.TabIndex = 6;
            Msplantab.Text = "MsPlan";
            Msplantab.UseVisualStyleBackColor = true;
            // 
            // Msplanduratilab
            // 
            Msplanduratilab.AutoSize = true;
            Msplanduratilab.Location = new Point(31, 171);
            Msplanduratilab.Name = "Msplanduratilab";
            Msplanduratilab.Size = new Size(67, 20);
            Msplanduratilab.TabIndex = 14;
            Msplanduratilab.Text = "Duration";
            // 
            // btnMsView1
            // 
            btnMsView1.BackColor = Color.Red;
            btnMsView1.ForeColor = Color.White;
            btnMsView1.Location = new Point(464, 256);
            btnMsView1.Name = "btnMsView1";
            btnMsView1.Size = new Size(101, 42);
            btnMsView1.TabIndex = 13;
            btnMsView1.Text = "View";
            btnMsView1.UseVisualStyleBackColor = false;
            btnMsView1.Click += btnMsView1_Click;
            // 
            // btnMsDelete1
            // 
            btnMsDelete1.BackColor = Color.Blue;
            btnMsDelete1.ForeColor = Color.White;
            btnMsDelete1.Location = new Point(462, 182);
            btnMsDelete1.Name = "btnMsDelete1";
            btnMsDelete1.Size = new Size(101, 42);
            btnMsDelete1.TabIndex = 12;
            btnMsDelete1.Text = "Delete";
            btnMsDelete1.UseVisualStyleBackColor = false;
            // 
            // btnMsUpdate1
            // 
            btnMsUpdate1.BackColor = Color.FromArgb(0, 192, 0);
            btnMsUpdate1.ForeColor = Color.White;
            btnMsUpdate1.Location = new Point(463, 107);
            btnMsUpdate1.Name = "btnMsUpdate1";
            btnMsUpdate1.Size = new Size(100, 42);
            btnMsUpdate1.TabIndex = 11;
            btnMsUpdate1.Text = "Update";
            btnMsUpdate1.UseVisualStyleBackColor = false;
            // 
            // btnMsAdd1
            // 
            btnMsAdd1.BackColor = Color.FromArgb(192, 0, 0);
            btnMsAdd1.ForeColor = Color.White;
            btnMsAdd1.Location = new Point(461, 36);
            btnMsAdd1.Name = "btnMsAdd1";
            btnMsAdd1.Size = new Size(102, 42);
            btnMsAdd1.TabIndex = 10;
            btnMsAdd1.Text = "Add";
            btnMsAdd1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(104, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 27);
            textBox5.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(104, 231);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(104, 169);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(178, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 107);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(174, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 36);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 27);
            textBox4.TabIndex = 5;
            // 
            // MsAssignlab
            // 
            MsAssignlab.AutoSize = true;
            MsAssignlab.Location = new Point(31, 295);
            MsAssignlab.Name = "MsAssignlab";
            MsAssignlab.Size = new Size(52, 20);
            MsAssignlab.TabIndex = 4;
            MsAssignlab.Text = "Assign";
            // 
            // MsDate1lab
            // 
            MsDate1lab.AutoSize = true;
            MsDate1lab.Location = new Point(31, 231);
            MsDate1lab.Name = "MsDate1lab";
            MsDate1lab.Size = new Size(41, 20);
            MsDate1lab.TabIndex = 3;
            MsDate1lab.Text = "Date";
            // 
            // MsMemelab
            // 
            MsMemelab.AutoSize = true;
            MsMemelab.Location = new Point(31, 110);
            MsMemelab.Name = "MsMemelab";
            MsMemelab.Size = new Size(71, 20);
            MsMemelab.TabIndex = 1;
            MsMemelab.Text = "Members";
            // 
            // Msplanlab
            // 
            Msplanlab.AutoSize = true;
            Msplanlab.Location = new Point(19, 43);
            Msplanlab.Name = "Msplanlab";
            Msplanlab.Size = new Size(83, 20);
            Msplanlab.TabIndex = 0;
            Msplanlab.Text = "Plan-Name";
            // 
            // MsProgresstab
            // 
            MsProgresstab.Controls.Add(btnMsView);
            MsProgresstab.Controls.Add(btnMsDelete);
            MsProgresstab.Controls.Add(btnMsUpdate);
            MsProgresstab.Controls.Add(btnMsAdd);
            MsProgresstab.Controls.Add(textBox3);
            MsProgresstab.Controls.Add(textBox2);
            MsProgresstab.Controls.Add(textBox1);
            MsProgresstab.Controls.Add(dateTimePicker1);
            MsProgresstab.Controls.Add(comboBox1);
            MsProgresstab.Controls.Add(Msnotelab);
            MsProgresstab.Controls.Add(Msweightlab);
            MsProgresstab.Controls.Add(Msbodylab);
            MsProgresstab.Controls.Add(Msdatelab);
            MsProgresstab.Controls.Add(Msnamelab);
            MsProgresstab.Location = new Point(4, 29);
            MsProgresstab.Name = "MsProgresstab";
            MsProgresstab.Padding = new Padding(3);
            MsProgresstab.Size = new Size(925, 443);
            MsProgresstab.TabIndex = 7;
            MsProgresstab.Text = "MsProgress";
            MsProgresstab.UseVisualStyleBackColor = true;
            // 
            // btnMsView
            // 
            btnMsView.BackColor = Color.FromArgb(0, 0, 192);
            btnMsView.ForeColor = Color.White;
            btnMsView.Location = new Point(422, 257);
            btnMsView.Name = "btnMsView";
            btnMsView.Size = new Size(107, 41);
            btnMsView.TabIndex = 13;
            btnMsView.Text = "View";
            btnMsView.UseVisualStyleBackColor = false;
            btnMsView.Click += btnMsView_Click;
            // 
            // btnMsDelete
            // 
            btnMsDelete.BackColor = Color.Red;
            btnMsDelete.ForeColor = Color.White;
            btnMsDelete.Location = new Point(422, 184);
            btnMsDelete.Name = "btnMsDelete";
            btnMsDelete.Size = new Size(107, 41);
            btnMsDelete.TabIndex = 12;
            btnMsDelete.Text = "Delete";
            btnMsDelete.UseVisualStyleBackColor = false;
            // 
            // btnMsUpdate
            // 
            btnMsUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnMsUpdate.ForeColor = Color.White;
            btnMsUpdate.Location = new Point(422, 110);
            btnMsUpdate.Name = "btnMsUpdate";
            btnMsUpdate.Size = new Size(110, 41);
            btnMsUpdate.TabIndex = 11;
            btnMsUpdate.Text = "Update";
            btnMsUpdate.UseVisualStyleBackColor = false;
            // 
            // btnMsAdd
            // 
            btnMsAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnMsAdd.ForeColor = Color.White;
            btnMsAdd.Location = new Point(422, 31);
            btnMsAdd.Name = "btnMsAdd";
            btnMsAdd.Size = new Size(101, 41);
            btnMsAdd.TabIndex = 10;
            btnMsAdd.Text = "Add";
            btnMsAdd.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 290);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(120, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 28);
            comboBox1.TabIndex = 5;
            // 
            // Msnotelab
            // 
            Msnotelab.AutoSize = true;
            Msnotelab.Location = new Point(46, 229);
            Msnotelab.Name = "Msnotelab";
            Msnotelab.Size = new Size(48, 20);
            Msnotelab.TabIndex = 4;
            Msnotelab.Text = "Notes";
            // 
            // Msweightlab
            // 
            Msweightlab.AutoSize = true;
            Msweightlab.Location = new Point(26, 297);
            Msweightlab.Name = "Msweightlab";
            Msweightlab.Size = new Size(86, 20);
            Msweightlab.TabIndex = 3;
            Msweightlab.Text = "Weight (kg)";
            // 
            // Msbodylab
            // 
            Msbodylab.AutoSize = true;
            Msbodylab.Location = new Point(26, 110);
            Msbodylab.Name = "Msbodylab";
            Msbodylab.Size = new Size(88, 20);
            Msbodylab.TabIndex = 2;
            Msbodylab.Text = "Body Fat(%)";
            // 
            // Msdatelab
            // 
            Msdatelab.AutoSize = true;
            Msdatelab.Location = new Point(46, 169);
            Msdatelab.Name = "Msdatelab";
            Msdatelab.Size = new Size(41, 20);
            Msdatelab.TabIndex = 1;
            Msdatelab.Text = "Date";
            // 
            // Msnamelab
            // 
            Msnamelab.AutoSize = true;
            Msnamelab.Location = new Point(26, 41);
            Msnamelab.Name = "Msnamelab";
            Msnamelab.Size = new Size(68, 20);
            Msnamelab.TabIndex = 0;
            Msnamelab.Text = "M-Name";
            // 
            // MsAttendancetab
            // 
            MsAttendancetab.Controls.Add(btnMSUpdateAttend);
            MsAttendancetab.Controls.Add(btnMsAddAttend);
            MsAttendancetab.Controls.Add(MsAttendlab1);
            MsAttendancetab.Controls.Add(dataGridView7);
            MsAttendancetab.Location = new Point(4, 29);
            MsAttendancetab.Name = "MsAttendancetab";
            MsAttendancetab.Padding = new Padding(3);
            MsAttendancetab.Size = new Size(925, 443);
            MsAttendancetab.TabIndex = 8;
            MsAttendancetab.Text = "MsAttendance";
            MsAttendancetab.UseVisualStyleBackColor = true;
            // 
            // btnMSUpdateAttend
            // 
            btnMSUpdateAttend.BackColor = Color.FromArgb(0, 192, 0);
            btnMSUpdateAttend.ForeColor = Color.White;
            btnMSUpdateAttend.Location = new Point(501, 88);
            btnMSUpdateAttend.Name = "btnMSUpdateAttend";
            btnMSUpdateAttend.Size = new Size(112, 46);
            btnMSUpdateAttend.TabIndex = 3;
            btnMSUpdateAttend.Text = "Update";
            btnMSUpdateAttend.UseVisualStyleBackColor = false;
            // 
            // btnMsAddAttend
            // 
            btnMsAddAttend.BackColor = Color.FromArgb(0, 0, 192);
            btnMsAddAttend.ForeColor = Color.White;
            btnMsAddAttend.Location = new Point(281, 88);
            btnMsAddAttend.Name = "btnMsAddAttend";
            btnMsAddAttend.Size = new Size(104, 46);
            btnMsAddAttend.TabIndex = 2;
            btnMsAddAttend.Text = "Add";
            btnMsAddAttend.UseVisualStyleBackColor = false;
            btnMsAddAttend.Click += btnMsAddAttend_Click;
            // 
            // MsAttendlab1
            // 
            MsAttendlab1.AutoSize = true;
            MsAttendlab1.BackColor = Color.Red;
            MsAttendlab1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MsAttendlab1.ForeColor = Color.White;
            MsAttendlab1.Location = new Point(258, 28);
            MsAttendlab1.Name = "MsAttendlab1";
            MsAttendlab1.Size = new Size(355, 37);
            MsAttendlab1.TabIndex = 1;
            MsAttendlab1.Text = "Memebers Attendance";
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Columns.AddRange(new DataGridViewColumn[] { MsName13, Date13, Status13 });
            dataGridView7.Location = new Point(77, 156);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.Size = new Size(772, 259);
            dataGridView7.TabIndex = 0;
            // 
            // MsName13
            // 
            MsName13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MsName13.HeaderText = "M-Name";
            MsName13.MinimumWidth = 6;
            MsName13.Name = "MsName13";
            // 
            // Date13
            // 
            Date13.HeaderText = "DATE";
            Date13.MinimumWidth = 6;
            Date13.Name = "Date13";
            Date13.Width = 125;
            // 
            // Status13
            // 
            Status13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status13.HeaderText = "Status";
            Status13.MinimumWidth = 6;
            Status13.Name = "Status13";
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.Crimson;
            Logoutbtn.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(835, 0);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(94, 29);
            Logoutbtn.TabIndex = 0;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(933, 476);
            Controls.Add(Logoutbtn);
            Controls.Add(tabcontrolMain);
            Controls.Add(Loginpanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainDashboard";
            Text = "Form1";
            Load += MainDashboard_Load;
            Loginpanel.ResumeLayout(false);
            Loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabcontrolMain.ResumeLayout(false);
            Registrationtab.ResumeLayout(false);
            Registrationtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Trainertab.ResumeLayout(false);
            Trainertab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Paymenttab.ResumeLayout(false);
            Paymenttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            MyPlantab.ResumeLayout(false);
            MyPlantab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            Mypaymenttab.ResumeLayout(false);
            Mypaymenttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            MyProgresstab.ResumeLayout(false);
            MyProgresstab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            Msplantab.ResumeLayout(false);
            Msplantab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            MsProgresstab.ResumeLayout(false);
            MsProgresstab.PerformLayout();
            MsAttendancetab.ResumeLayout(false);
            MsAttendancetab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Loginpanel;
        private Button buttonLogin;
        private Label Passwordlabel;
        private Label Usernamelabel;
        private TextBox txtboxPassword;
        private PictureBox pictureBox1;
        private TabControl tabcontrolMain;
        private TabPage Registrationtab;
        private TabPage Trainertab;
        private TabPage Paymenttab;
        private TabPage MyPlantab;
        private TabPage Mypaymenttab;
        private TabPage MyProgresstab;
        private TabPage Msplantab;
        private TabPage MsProgresstab;
        private TabPage MsAttendancetab;
        private TextBox txtboxUsername;
        private Label Title;
        private Button Logoutbtn;
        private Label label5;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Pmember;
        private DataGridViewTextBoxColumn PDate;
        private DataGridViewTextBoxColumn PAmount;
        private DataGridViewTextBoxColumn PFor;
        private PictureBox pictureBox2;
        private Label label6;
        private DataGridView dataGridView2;
        private Button btnAddMember;
        private Button btnTestConnection;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Tname;
        private DataGridViewTextBoxColumn txtspecality;
        private DataGridViewTextBoxColumn txtPhoneTrainer;
        private DataGridViewTextBoxColumn dtpHireDate;
        private Button btnAddTrainer;
        private Label label7;
        private Button button1;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn PlanName1;
        private DataGridViewTextBoxColumn Duration1;
        private DataGridViewTextBoxColumn Trainer;
        private DataGridViewTextBoxColumn Date1;
        private DataGridViewTextBoxColumn Assigned1;
        private Label label1;
        private Button btnrefreshMplan;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn Date2;
        private DataGridViewTextBoxColumn Amount2;
        private DataGridViewTextBoxColumn Description2;
        private Label MYPaymentlab;
        private Button btnrefreshMyPay;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn Date3;
        private DataGridViewTextBoxColumn Weight3;
        private DataGridViewTextBoxColumn BodyFat1;
        private DataGridViewTextBoxColumn Notes1;
        private Label MyprogressLab;
        private Button btnrefreshmypro;
        private Label Msweightlab;
        private Label Msbodylab;
        private Label Msdatelab;
        private Label Msnamelab;
        private Label Msnotelab;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnMsDelete;
        private Button btnMsUpdate;
        private Button btnMsAdd;
        private Button btnMsView;
        private Label MsAssignlab;
        private Label MsDate1lab;
        private Label MsMemelab;
        private Label Msplanlab;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private Button btnMsView1;
        private Button btnMsDelete1;
        private Button btnMsUpdate1;
        private Button btnMsAdd1;
        private Label MsAttendlab1;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn MsName13;
        private DataGridViewTextBoxColumn Date13;
        private DataGridViewTextBoxColumn Status13;
        private Button btnMSUpdateAttend;
        private Button btnMsAddAttend;
        private Label Msplanduratilab;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn MemberID;
        private DataGridViewTextBoxColumn FNameColumn;
        private DataGridViewTextBoxColumn Lname1;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn MemberShipType1;
        private Button btnAddAccount;
    }
}
