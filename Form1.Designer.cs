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
            btnRefreshMembers = new Button();
            Btndelete48 = new Button();
            btnAddAccount = new Button();
            btnTestConnection = new Button();
            dgvMembers = new DataGridView();
            MemberID = new DataGridViewTextBoxColumn();
            Accountdi = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            MemberShipType = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewCheckBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Mode = new DataGridViewButtonColumn();
            btnAddMember = new Button();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            Trainertab = new TabPage();
            refreshtrain2433 = new Button();
            deletetrainbtn23 = new Button();
            dgvTrainers = new DataGridView();
            TrainerID = new DataGridViewTextBoxColumn();
            Accountme = new DataGridViewTextBoxColumn();
            Tfirstname = new DataGridViewTextBoxColumn();
            Tlastname = new DataGridViewTextBoxColumn();
            Tspecialization = new DataGridViewTextBoxColumn();
            Edittrainer = new DataGridViewButtonColumn();
            DeleteTrainer = new DataGridViewCheckBoxColumn();
            StatusTrainer = new DataGridViewTextBoxColumn();
            ModeTrainer = new DataGridViewButtonColumn();
            btnAddTrainer = new Button();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            Paymenttab = new TabPage();
            btnRefreshPayments = new Button();
            deletepaybtn21 = new Button();
            dgvPayments = new DataGridView();
            button3 = new Button();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            MyPlantab = new TabPage();
            btnrefreshMplan = new Button();
            dgvMPlan = new DataGridView();
            Planid1 = new DataGridViewTextBoxColumn();
            Duration1 = new DataGridViewTextBoxColumn();
            Trainer = new DataGridViewTextBoxColumn();
            Assigned1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            Mypaymenttab = new TabPage();
            btnrefreshMyPay = new Button();
            dgvMyPayment = new DataGridView();
            payDate = new DataGridViewTextBoxColumn();
            Amount2 = new DataGridViewTextBoxColumn();
            Description2 = new DataGridViewTextBoxColumn();
            MYPaymentlab = new Label();
            pictureBox8 = new PictureBox();
            Msplantab = new TabPage();
            Mplaninnglab1 = new Label();
            btnRefreshPlans = new Button();
            dgvPlans = new DataGridView();
            Planid = new DataGridViewTextBoxColumn();
            Memberdi = new DataGridViewTextBoxColumn();
            Membersgrid1 = new DataGridViewTextBoxColumn();
            Durationgrid1 = new DataGridViewTextBoxColumn();
            Assignedgrid1 = new DataGridViewTextBoxColumn();
            Editplan = new DataGridViewButtonColumn();
            Deleteplan = new DataGridViewCheckBoxColumn();
            Statusmembers = new DataGridViewTextBoxColumn();
            btnDeletePlan = new Button();
            btnMsAdd1 = new Button();
            pictureBox10 = new PictureBox();
            MsAttendancetab = new TabPage();
            btnDeleteAttendance = new Button();
            btnRefreshAttendance = new Button();
            btnMsAddAttend = new Button();
            MsAttendlab1 = new Label();
            dgvAttendance = new DataGridView();
            Attendanceid = new DataGridViewTextBoxColumn();
            MsMemberId = new DataGridViewTextBoxColumn();
            MsName13 = new DataGridViewTextBoxColumn();
            Date13 = new DataGridViewTextBoxColumn();
            Status13 = new DataGridViewTextBoxColumn();
            Editattend = new DataGridViewButtonColumn();
            Deleteattend = new DataGridViewCheckBoxColumn();
            pictureBox12 = new PictureBox();
            Logoutbtn = new Button();
            Paymentid = new DataGridViewTextBoxColumn();
            Memberdd = new DataGridViewTextBoxColumn();
            Pmember = new DataGridViewTextBoxColumn();
            PaymentDate = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Editpayment = new DataGridViewButtonColumn();
            Deletepayment = new DataGridViewCheckBoxColumn();
            Statusmemb = new DataGridViewTextBoxColumn();
            Loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabcontrolMain.SuspendLayout();
            Registrationtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            Trainertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Paymenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            MyPlantab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            Mypaymenttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            Msplantab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            MsAttendancetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
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
            Loginpanel.Size = new Size(1253, 544);
            Loginpanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(820, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 32);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Crimson;
            Title.Location = new Point(512, 32);
            Title.Name = "Title";
            Title.Size = new Size(238, 37);
            Title.TabIndex = 7;
            Title.Text = "FITNESS CENTER";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsername.Location = new Point(628, 128);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(225, 38);
            txtboxUsername.TabIndex = 6;
            txtboxUsername.KeyPress += txtboxUsername_KeyPress;
            // 
            // txtboxPassword
            // 
            txtboxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPassword.Location = new Point(628, 236);
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
            buttonLogin.Location = new Point(568, 345);
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
            Passwordlabel.Location = new Point(472, 236);
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
            Usernamelabel.Location = new Point(464, 139);
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
            pictureBox1.Size = new Size(1253, 544);
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
            tabcontrolMain.Controls.Add(Msplantab);
            tabcontrolMain.Controls.Add(MsAttendancetab);
            tabcontrolMain.Dock = DockStyle.Fill;
            tabcontrolMain.Location = new Point(0, 0);
            tabcontrolMain.Name = "tabcontrolMain";
            tabcontrolMain.SelectedIndex = 0;
            tabcontrolMain.Size = new Size(1253, 544);
            tabcontrolMain.TabIndex = 6;
            // 
            // Registrationtab
            // 
            Registrationtab.Controls.Add(btnRefreshMembers);
            Registrationtab.Controls.Add(Btndelete48);
            Registrationtab.Controls.Add(btnAddAccount);
            Registrationtab.Controls.Add(btnTestConnection);
            Registrationtab.Controls.Add(dgvMembers);
            Registrationtab.Controls.Add(btnAddMember);
            Registrationtab.Controls.Add(label6);
            Registrationtab.Controls.Add(pictureBox5);
            Registrationtab.Location = new Point(4, 29);
            Registrationtab.Name = "Registrationtab";
            Registrationtab.Padding = new Padding(3);
            Registrationtab.Size = new Size(1245, 511);
            Registrationtab.TabIndex = 0;
            Registrationtab.Text = "Registration";
            Registrationtab.UseVisualStyleBackColor = true;
            Registrationtab.Click += Registrationtab_Click;
            // 
            // btnRefreshMembers
            // 
            btnRefreshMembers.BackColor = Color.Maroon;
            btnRefreshMembers.ForeColor = Color.White;
            btnRefreshMembers.Location = new Point(948, 98);
            btnRefreshMembers.Name = "btnRefreshMembers";
            btnRefreshMembers.Size = new Size(126, 47);
            btnRefreshMembers.TabIndex = 6;
            btnRefreshMembers.Text = "REFRESH";
            btnRefreshMembers.UseVisualStyleBackColor = false;
            btnRefreshMembers.Click += btnRefreshMembers_Click;
            // 
            // Btndelete48
            // 
            Btndelete48.BackColor = Color.Maroon;
            Btndelete48.ForeColor = Color.White;
            Btndelete48.Location = new Point(751, 98);
            Btndelete48.Name = "Btndelete48";
            Btndelete48.Size = new Size(117, 47);
            Btndelete48.TabIndex = 5;
            Btndelete48.Text = "Delete";
            Btndelete48.UseVisualStyleBackColor = false;
            Btndelete48.Click += Btndelete48_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.Maroon;
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.Location = new Point(534, 99);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(126, 47);
            btnAddAccount.TabIndex = 4;
            btnAddAccount.Text = "AddStaff";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.Maroon;
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(83, 99);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(147, 47);
            btnTestConnection.TabIndex = 3;
            btnTestConnection.Text = "Test-Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { MemberID, Accountdi, FirstName, LastName, Age, Gender, MemberShipType, Edit, Delete, Status, Mode });
            dgvMembers.Location = new Point(1, 167);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(1240, 341);
            dgvMembers.TabIndex = 2;
            dgvMembers.CellContentClick += dataGridView2_CellContentClick;
            // 
            // MemberID
            // 
            MemberID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MemberID.DataPropertyName = "MemberId";
            MemberID.HeaderText = "MemberId";
            MemberID.MinimumWidth = 6;
            MemberID.Name = "MemberID";
            MemberID.Width = 110;
            // 
            // Accountdi
            // 
            Accountdi.DataPropertyName = "AccountId";
            Accountdi.HeaderText = "AccountId";
            Accountdi.MinimumWidth = 6;
            Accountdi.Name = "Accountdi";
            Accountdi.Visible = false;
            Accountdi.Width = 125;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 110;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 125;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Age.DataPropertyName = "Age";
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 109;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 109;
            // 
            // MemberShipType
            // 
            MemberShipType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MemberShipType.DataPropertyName = "MemberShipType";
            MemberShipType.HeaderText = "MemberShipType";
            MemberShipType.MinimumWidth = 6;
            MemberShipType.Name = "MemberShipType";
            MemberShipType.Width = 125;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 125;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Mode
            // 
            Mode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Mode.DataPropertyName = "Mode";
            Mode.HeaderText = "Mode";
            Mode.MinimumWidth = 6;
            Mode.Name = "Mode";
            Mode.Width = 125;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.Maroon;
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(315, 99);
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
            label6.Location = new Point(446, 20);
            label6.Name = "label6";
            label6.Size = new Size(327, 37);
            label6.TabIndex = 0;
            label6.Text = "Member Registration ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1239, 505);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // Trainertab
            // 
            Trainertab.Controls.Add(refreshtrain2433);
            Trainertab.Controls.Add(deletetrainbtn23);
            Trainertab.Controls.Add(dgvTrainers);
            Trainertab.Controls.Add(btnAddTrainer);
            Trainertab.Controls.Add(label7);
            Trainertab.Controls.Add(pictureBox4);
            Trainertab.Location = new Point(4, 29);
            Trainertab.Name = "Trainertab";
            Trainertab.Padding = new Padding(3);
            Trainertab.Size = new Size(1245, 511);
            Trainertab.TabIndex = 1;
            Trainertab.Text = "TrainerManagement";
            Trainertab.UseVisualStyleBackColor = true;
            // 
            // refreshtrain2433
            // 
            refreshtrain2433.BackColor = Color.Maroon;
            refreshtrain2433.ForeColor = Color.White;
            refreshtrain2433.Location = new Point(816, 93);
            refreshtrain2433.Name = "refreshtrain2433";
            refreshtrain2433.Size = new Size(116, 41);
            refreshtrain2433.TabIndex = 5;
            refreshtrain2433.Text = "Refresh";
            refreshtrain2433.UseVisualStyleBackColor = false;
            refreshtrain2433.Click += refreshtrain2433_Click;
            // 
            // deletetrainbtn23
            // 
            deletetrainbtn23.BackColor = Color.Maroon;
            deletetrainbtn23.ForeColor = Color.White;
            deletetrainbtn23.Location = new Point(553, 93);
            deletetrainbtn23.Name = "deletetrainbtn23";
            deletetrainbtn23.Size = new Size(116, 41);
            deletetrainbtn23.TabIndex = 4;
            deletetrainbtn23.Text = "Delete";
            deletetrainbtn23.UseVisualStyleBackColor = false;
            deletetrainbtn23.Click += deletetrainbtn23_Click;
            // 
            // dgvTrainers
            // 
            dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainers.Columns.AddRange(new DataGridViewColumn[] { TrainerID, Accountme, Tfirstname, Tlastname, Tspecialization, Edittrainer, DeleteTrainer, StatusTrainer, ModeTrainer });
            dgvTrainers.Location = new Point(3, 140);
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.RowHeadersWidth = 51;
            dgvTrainers.Size = new Size(1239, 363);
            dgvTrainers.TabIndex = 2;
            // 
            // TrainerID
            // 
            TrainerID.DataPropertyName = "Trainerid";
            TrainerID.HeaderText = "Trainerid";
            TrainerID.MinimumWidth = 6;
            TrainerID.Name = "TrainerID";
            TrainerID.Width = 125;
            // 
            // Accountme
            // 
            Accountme.DataPropertyName = "AccountId";
            Accountme.HeaderText = "AccountId";
            Accountme.MinimumWidth = 6;
            Accountme.Name = "Accountme";
            Accountme.Visible = false;
            Accountme.Width = 125;
            // 
            // Tfirstname
            // 
            Tfirstname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tfirstname.DataPropertyName = "FirstName";
            Tfirstname.HeaderText = "FirstName";
            Tfirstname.MinimumWidth = 6;
            Tfirstname.Name = "Tfirstname";
            // 
            // Tlastname
            // 
            Tlastname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tlastname.DataPropertyName = "LastName";
            Tlastname.HeaderText = "LastName";
            Tlastname.MinimumWidth = 6;
            Tlastname.Name = "Tlastname";
            // 
            // Tspecialization
            // 
            Tspecialization.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tspecialization.DataPropertyName = "Specialization";
            Tspecialization.HeaderText = "Specialization";
            Tspecialization.MinimumWidth = 6;
            Tspecialization.Name = "Tspecialization";
            // 
            // Edittrainer
            // 
            Edittrainer.HeaderText = "Edit";
            Edittrainer.MinimumWidth = 6;
            Edittrainer.Name = "Edittrainer";
            Edittrainer.Width = 125;
            // 
            // DeleteTrainer
            // 
            DeleteTrainer.HeaderText = "Delete";
            DeleteTrainer.MinimumWidth = 6;
            DeleteTrainer.Name = "DeleteTrainer";
            DeleteTrainer.Width = 125;
            // 
            // StatusTrainer
            // 
            StatusTrainer.DataPropertyName = "Status";
            StatusTrainer.HeaderText = "Status";
            StatusTrainer.MinimumWidth = 6;
            StatusTrainer.Name = "StatusTrainer";
            StatusTrainer.Width = 125;
            // 
            // ModeTrainer
            // 
            ModeTrainer.HeaderText = "Mode";
            ModeTrainer.MinimumWidth = 6;
            ModeTrainer.Name = "ModeTrainer";
            ModeTrainer.Width = 125;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.BackColor = Color.Maroon;
            btnAddTrainer.ForeColor = Color.White;
            btnAddTrainer.Location = new Point(293, 93);
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
            label7.Location = new Point(438, 14);
            label7.Name = "label7";
            label7.Size = new Size(323, 37);
            label7.TabIndex = 0;
            label7.Text = "Trainer-Management";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1239, 505);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // Paymenttab
            // 
            Paymenttab.Controls.Add(btnRefreshPayments);
            Paymenttab.Controls.Add(deletepaybtn21);
            Paymenttab.Controls.Add(dgvPayments);
            Paymenttab.Controls.Add(button3);
            Paymenttab.Controls.Add(label5);
            Paymenttab.Controls.Add(pictureBox6);
            Paymenttab.Location = new Point(4, 29);
            Paymenttab.Name = "Paymenttab";
            Paymenttab.Padding = new Padding(3);
            Paymenttab.Size = new Size(1245, 511);
            Paymenttab.TabIndex = 2;
            Paymenttab.Text = "Payment";
            Paymenttab.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPayments
            // 
            btnRefreshPayments.BackColor = Color.Maroon;
            btnRefreshPayments.ForeColor = Color.White;
            btnRefreshPayments.Location = new Point(295, 124);
            btnRefreshPayments.Name = "btnRefreshPayments";
            btnRefreshPayments.Size = new Size(107, 42);
            btnRefreshPayments.TabIndex = 18;
            btnRefreshPayments.Text = "Refresh";
            btnRefreshPayments.UseVisualStyleBackColor = false;
            btnRefreshPayments.Click += btnRefreshPayments_Click_1;
            // 
            // deletepaybtn21
            // 
            deletepaybtn21.BackColor = Color.Maroon;
            deletepaybtn21.ForeColor = Color.White;
            deletepaybtn21.Location = new Point(564, 124);
            deletepaybtn21.Name = "deletepaybtn21";
            deletepaybtn21.Size = new Size(107, 42);
            deletepaybtn21.TabIndex = 17;
            deletepaybtn21.Text = "Delete";
            deletepaybtn21.UseVisualStyleBackColor = false;
            deletepaybtn21.Click += deletepaybtn21_Click;
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { Paymentid, Memberdd, Pmember, PaymentDate, Amount, Editpayment, Deletepayment, Statusmemb });
            dgvPayments.Location = new Point(135, 188);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.Size = new Size(1005, 270);
            dgvPayments.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.ForeColor = Color.White;
            button3.Location = new Point(816, 124);
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
            label5.Location = new Point(524, 22);
            label5.Name = "label5";
            label5.Size = new Size(147, 37);
            label5.TabIndex = 4;
            label5.Text = "Payment";
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1239, 505);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // MyPlantab
            // 
            MyPlantab.Controls.Add(btnrefreshMplan);
            MyPlantab.Controls.Add(dgvMPlan);
            MyPlantab.Controls.Add(label1);
            MyPlantab.Controls.Add(pictureBox7);
            MyPlantab.Location = new Point(4, 29);
            MyPlantab.Name = "MyPlantab";
            MyPlantab.Padding = new Padding(3);
            MyPlantab.Size = new Size(1245, 511);
            MyPlantab.TabIndex = 3;
            MyPlantab.Text = "MyPlan";
            MyPlantab.UseVisualStyleBackColor = true;
            // 
            // btnrefreshMplan
            // 
            btnrefreshMplan.BackColor = Color.Maroon;
            btnrefreshMplan.ForeColor = Color.White;
            btnrefreshMplan.Location = new Point(553, 79);
            btnrefreshMplan.Name = "btnrefreshMplan";
            btnrefreshMplan.Size = new Size(134, 41);
            btnrefreshMplan.TabIndex = 2;
            btnrefreshMplan.Text = "Refresh";
            btnrefreshMplan.UseVisualStyleBackColor = false;
            btnrefreshMplan.Click += btnrefreshMplan_Click;
            // 
            // dgvMPlan
            // 
            dgvMPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMPlan.Columns.AddRange(new DataGridViewColumn[] { Planid1, Duration1, Trainer, Assigned1 });
            dgvMPlan.Location = new Point(308, 126);
            dgvMPlan.Name = "dgvMPlan";
            dgvMPlan.RowHeadersWidth = 51;
            dgvMPlan.Size = new Size(636, 302);
            dgvMPlan.TabIndex = 1;
            // 
            // Planid1
            // 
            Planid1.DataPropertyName = "PlanId";
            Planid1.HeaderText = "PlanId";
            Planid1.MinimumWidth = 6;
            Planid1.Name = "Planid1";
            Planid1.Width = 125;
            // 
            // Duration1
            // 
            Duration1.DataPropertyName = "Duration";
            Duration1.HeaderText = "Duration";
            Duration1.MinimumWidth = 6;
            Duration1.Name = "Duration1";
            Duration1.Width = 125;
            // 
            // Trainer
            // 
            Trainer.DataPropertyName = "Trainer";
            Trainer.HeaderText = "Trainer";
            Trainer.MinimumWidth = 6;
            Trainer.Name = "Trainer";
            Trainer.Width = 125;
            // 
            // Assigned1
            // 
            Assigned1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Assigned1.DataPropertyName = "AssignedDate";
            Assigned1.HeaderText = "AssignedDate";
            Assigned1.MinimumWidth = 6;
            Assigned1.Name = "Assigned1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(470, 13);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 0;
            label1.Text = "My Workout-Plan";
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1239, 505);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // Mypaymenttab
            // 
            Mypaymenttab.Controls.Add(btnrefreshMyPay);
            Mypaymenttab.Controls.Add(dgvMyPayment);
            Mypaymenttab.Controls.Add(MYPaymentlab);
            Mypaymenttab.Controls.Add(pictureBox8);
            Mypaymenttab.Location = new Point(4, 29);
            Mypaymenttab.Name = "Mypaymenttab";
            Mypaymenttab.Padding = new Padding(3);
            Mypaymenttab.Size = new Size(1245, 511);
            Mypaymenttab.TabIndex = 4;
            Mypaymenttab.Text = "MyPayment";
            Mypaymenttab.UseVisualStyleBackColor = true;
            // 
            // btnrefreshMyPay
            // 
            btnrefreshMyPay.BackColor = Color.Maroon;
            btnrefreshMyPay.ForeColor = Color.White;
            btnrefreshMyPay.Location = new Point(528, 119);
            btnrefreshMyPay.Name = "btnrefreshMyPay";
            btnrefreshMyPay.Size = new Size(135, 46);
            btnrefreshMyPay.TabIndex = 2;
            btnrefreshMyPay.Text = "Refresh";
            btnrefreshMyPay.UseVisualStyleBackColor = false;
            btnrefreshMyPay.Click += btnrefreshMyPay_Click;
            // 
            // dgvMyPayment
            // 
            dgvMyPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyPayment.Columns.AddRange(new DataGridViewColumn[] { payDate, Amount2, Description2 });
            dgvMyPayment.Location = new Point(252, 189);
            dgvMyPayment.Name = "dgvMyPayment";
            dgvMyPayment.RowHeadersWidth = 51;
            dgvMyPayment.Size = new Size(706, 219);
            dgvMyPayment.TabIndex = 1;
            // 
            // payDate
            // 
            payDate.DataPropertyName = "PaymentDate";
            payDate.HeaderText = "PaymentDate";
            payDate.MinimumWidth = 6;
            payDate.Name = "payDate";
            payDate.Width = 125;
            // 
            // Amount2
            // 
            Amount2.DataPropertyName = "Amount";
            Amount2.HeaderText = "Amount";
            Amount2.MinimumWidth = 6;
            Amount2.Name = "Amount2";
            Amount2.Width = 125;
            // 
            // Description2
            // 
            Description2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description2.DataPropertyName = "Description";
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
            MYPaymentlab.Location = new Point(426, 40);
            MYPaymentlab.Name = "MYPaymentlab";
            MYPaymentlab.Size = new Size(304, 37);
            MYPaymentlab.TabIndex = 0;
            MYPaymentlab.Text = "My Payment History";
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(1239, 505);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // Msplantab
            // 
            Msplantab.Controls.Add(Mplaninnglab1);
            Msplantab.Controls.Add(btnRefreshPlans);
            Msplantab.Controls.Add(dgvPlans);
            Msplantab.Controls.Add(btnDeletePlan);
            Msplantab.Controls.Add(btnMsAdd1);
            Msplantab.Controls.Add(pictureBox10);
            Msplantab.Location = new Point(4, 29);
            Msplantab.Name = "Msplantab";
            Msplantab.Padding = new Padding(3);
            Msplantab.Size = new Size(1245, 511);
            Msplantab.TabIndex = 6;
            Msplantab.Text = "MsPlan";
            Msplantab.UseVisualStyleBackColor = true;
            // 
            // Mplaninnglab1
            // 
            Mplaninnglab1.AutoSize = true;
            Mplaninnglab1.BackColor = Color.FromArgb(128, 64, 0);
            Mplaninnglab1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mplaninnglab1.ForeColor = Color.White;
            Mplaninnglab1.Location = new Point(439, 21);
            Mplaninnglab1.Name = "Mplaninnglab1";
            Mplaninnglab1.Size = new Size(270, 37);
            Mplaninnglab1.TabIndex = 15;
            Mplaninnglab1.Text = "Members-Planing";
            // 
            // btnRefreshPlans
            // 
            btnRefreshPlans.BackColor = Color.Maroon;
            btnRefreshPlans.ForeColor = Color.White;
            btnRefreshPlans.Location = new Point(528, 137);
            btnRefreshPlans.Name = "btnRefreshPlans";
            btnRefreshPlans.Size = new Size(102, 42);
            btnRefreshPlans.TabIndex = 14;
            btnRefreshPlans.Text = "Refresh";
            btnRefreshPlans.UseVisualStyleBackColor = false;
            btnRefreshPlans.Click += btnRefreshPlans_Click;
            // 
            // dgvPlans
            // 
            dgvPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlans.Columns.AddRange(new DataGridViewColumn[] { Planid, Memberdi, Membersgrid1, Durationgrid1, Assignedgrid1, Editplan, Deleteplan, Statusmembers });
            dgvPlans.Location = new Point(27, 196);
            dgvPlans.Name = "dgvPlans";
            dgvPlans.RowHeadersWidth = 51;
            dgvPlans.Size = new Size(1191, 225);
            dgvPlans.TabIndex = 13;
            // 
            // Planid
            // 
            Planid.DataPropertyName = "PlanId";
            Planid.HeaderText = "Planid";
            Planid.MinimumWidth = 6;
            Planid.Name = "Planid";
            Planid.Width = 125;
            // 
            // Memberdi
            // 
            Memberdi.DataPropertyName = "MemberId";
            Memberdi.HeaderText = "MemberId";
            Memberdi.MinimumWidth = 6;
            Memberdi.Name = "Memberdi";
            Memberdi.Visible = false;
            Memberdi.Width = 125;
            // 
            // Membersgrid1
            // 
            Membersgrid1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Membersgrid1.DataPropertyName = "MemberFullName";
            Membersgrid1.HeaderText = "Member";
            Membersgrid1.MinimumWidth = 6;
            Membersgrid1.Name = "Membersgrid1";
            // 
            // Durationgrid1
            // 
            Durationgrid1.DataPropertyName = "Duration";
            Durationgrid1.HeaderText = "Duration";
            Durationgrid1.MinimumWidth = 6;
            Durationgrid1.Name = "Durationgrid1";
            Durationgrid1.Width = 125;
            // 
            // Assignedgrid1
            // 
            Assignedgrid1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Assignedgrid1.DataPropertyName = "AssignedDate";
            Assignedgrid1.HeaderText = "AssignedDate";
            Assignedgrid1.MinimumWidth = 6;
            Assignedgrid1.Name = "Assignedgrid1";
            // 
            // Editplan
            // 
            Editplan.HeaderText = "Edit";
            Editplan.MinimumWidth = 6;
            Editplan.Name = "Editplan";
            Editplan.Width = 125;
            // 
            // Deleteplan
            // 
            Deleteplan.HeaderText = "Delete";
            Deleteplan.MinimumWidth = 6;
            Deleteplan.Name = "Deleteplan";
            Deleteplan.Width = 125;
            // 
            // Statusmembers
            // 
            Statusmembers.DataPropertyName = "Status";
            Statusmembers.HeaderText = "Status";
            Statusmembers.MinimumWidth = 6;
            Statusmembers.Name = "Statusmembers";
            Statusmembers.Width = 125;
            // 
            // btnDeletePlan
            // 
            btnDeletePlan.BackColor = Color.Maroon;
            btnDeletePlan.ForeColor = Color.White;
            btnDeletePlan.Location = new Point(816, 137);
            btnDeletePlan.Name = "btnDeletePlan";
            btnDeletePlan.Size = new Size(101, 42);
            btnDeletePlan.TabIndex = 12;
            btnDeletePlan.Text = "Delete";
            btnDeletePlan.UseVisualStyleBackColor = false;
            btnDeletePlan.Click += btnDeletePlan_Click;
            // 
            // btnMsAdd1
            // 
            btnMsAdd1.BackColor = Color.Maroon;
            btnMsAdd1.ForeColor = Color.White;
            btnMsAdd1.Location = new Point(275, 137);
            btnMsAdd1.Name = "btnMsAdd1";
            btnMsAdd1.Size = new Size(102, 42);
            btnMsAdd1.TabIndex = 10;
            btnMsAdd1.Text = "Add";
            btnMsAdd1.UseVisualStyleBackColor = false;
            btnMsAdd1.Click += btnMsAdd1_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Dock = DockStyle.Fill;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(3, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(1239, 505);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            // 
            // MsAttendancetab
            // 
            MsAttendancetab.Controls.Add(btnDeleteAttendance);
            MsAttendancetab.Controls.Add(btnRefreshAttendance);
            MsAttendancetab.Controls.Add(btnMsAddAttend);
            MsAttendancetab.Controls.Add(MsAttendlab1);
            MsAttendancetab.Controls.Add(dgvAttendance);
            MsAttendancetab.Controls.Add(pictureBox12);
            MsAttendancetab.Location = new Point(4, 29);
            MsAttendancetab.Name = "MsAttendancetab";
            MsAttendancetab.Padding = new Padding(3);
            MsAttendancetab.Size = new Size(1245, 511);
            MsAttendancetab.TabIndex = 8;
            MsAttendancetab.Text = "MsAttendance";
            MsAttendancetab.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAttendance
            // 
            btnDeleteAttendance.BackColor = Color.Maroon;
            btnDeleteAttendance.ForeColor = Color.White;
            btnDeleteAttendance.Location = new Point(784, 98);
            btnDeleteAttendance.Name = "btnDeleteAttendance";
            btnDeleteAttendance.Size = new Size(104, 46);
            btnDeleteAttendance.TabIndex = 6;
            btnDeleteAttendance.Text = "Delete";
            btnDeleteAttendance.UseVisualStyleBackColor = false;
            btnDeleteAttendance.Click += btnDeleteAttendance_Click;
            // 
            // btnRefreshAttendance
            // 
            btnRefreshAttendance.BackColor = Color.Maroon;
            btnRefreshAttendance.ForeColor = Color.White;
            btnRefreshAttendance.Location = new Point(564, 98);
            btnRefreshAttendance.Name = "btnRefreshAttendance";
            btnRefreshAttendance.Size = new Size(104, 46);
            btnRefreshAttendance.TabIndex = 5;
            btnRefreshAttendance.Text = "Refresh";
            btnRefreshAttendance.UseVisualStyleBackColor = false;
            btnRefreshAttendance.Click += btnRefreshAttendance_Click;
            // 
            // btnMsAddAttend
            // 
            btnMsAddAttend.BackColor = Color.Maroon;
            btnMsAddAttend.ForeColor = Color.White;
            btnMsAddAttend.Location = new Point(325, 98);
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
            MsAttendlab1.Location = new Point(430, 15);
            MsAttendlab1.Name = "MsAttendlab1";
            MsAttendlab1.Size = new Size(355, 37);
            MsAttendlab1.TabIndex = 1;
            MsAttendlab1.Text = "Memebers Attendance";
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { Attendanceid, MsMemberId, MsName13, Date13, Status13, Editattend, Deleteattend });
            dgvAttendance.Location = new Point(204, 183);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(829, 259);
            dgvAttendance.TabIndex = 0;
            // 
            // Attendanceid
            // 
            Attendanceid.DataPropertyName = "AttendanceId";
            Attendanceid.HeaderText = "AttendanceId";
            Attendanceid.MinimumWidth = 6;
            Attendanceid.Name = "Attendanceid";
            Attendanceid.Width = 125;
            // 
            // MsMemberId
            // 
            MsMemberId.DataPropertyName = "MemberId";
            MsMemberId.HeaderText = "MemberId";
            MsMemberId.MinimumWidth = 6;
            MsMemberId.Name = "MsMemberId";
            MsMemberId.Visible = false;
            MsMemberId.Width = 125;
            // 
            // MsName13
            // 
            MsName13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MsName13.DataPropertyName = "MemberFullName";
            MsName13.HeaderText = "Member";
            MsName13.MinimumWidth = 6;
            MsName13.Name = "MsName13";
            // 
            // Date13
            // 
            Date13.DataPropertyName = "Date";
            Date13.HeaderText = "Date";
            Date13.MinimumWidth = 6;
            Date13.Name = "Date13";
            Date13.Width = 125;
            // 
            // Status13
            // 
            Status13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status13.DataPropertyName = "Status";
            Status13.HeaderText = "Status";
            Status13.MinimumWidth = 6;
            Status13.Name = "Status13";
            // 
            // Editattend
            // 
            Editattend.HeaderText = "Edit";
            Editattend.MinimumWidth = 6;
            Editattend.Name = "Editattend";
            Editattend.Width = 125;
            // 
            // Deleteattend
            // 
            Deleteattend.HeaderText = "Delete";
            Deleteattend.MinimumWidth = 6;
            Deleteattend.Name = "Deleteattend";
            Deleteattend.Width = 125;
            // 
            // pictureBox12
            // 
            pictureBox12.Dock = DockStyle.Fill;
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(3, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(1239, 505);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 4;
            pictureBox12.TabStop = false;
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = Color.Crimson;
            Logoutbtn.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(1144, 0);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(94, 29);
            Logoutbtn.TabIndex = 0;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // Paymentid
            // 
            Paymentid.DataPropertyName = "PaymentId";
            Paymentid.HeaderText = "PaymentId";
            Paymentid.MinimumWidth = 6;
            Paymentid.Name = "Paymentid";
            Paymentid.Width = 125;
            // 
            // Memberdd
            // 
            Memberdd.DataPropertyName = "MemberId";
            Memberdd.HeaderText = "MemberId";
            Memberdd.MinimumWidth = 6;
            Memberdd.Name = "Memberdd";
            Memberdd.Visible = false;
            Memberdd.Width = 125;
            // 
            // Pmember
            // 
            Pmember.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pmember.DataPropertyName = "MemberFullName";
            Pmember.HeaderText = "Member";
            Pmember.MinimumWidth = 6;
            Pmember.Name = "Pmember";
            // 
            // PaymentDate
            // 
            PaymentDate.DataPropertyName = "PaymentDate";
            PaymentDate.HeaderText = "PaymentDate";
            PaymentDate.MinimumWidth = 6;
            PaymentDate.Name = "PaymentDate";
            PaymentDate.Width = 125;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // Editpayment
            // 
            Editpayment.HeaderText = "Edit";
            Editpayment.MinimumWidth = 6;
            Editpayment.Name = "Editpayment";
            Editpayment.Width = 125;
            // 
            // Deletepayment
            // 
            Deletepayment.HeaderText = "Delete";
            Deletepayment.MinimumWidth = 6;
            Deletepayment.Name = "Deletepayment";
            Deletepayment.Width = 125;
            // 
            // Statusmemb
            // 
            Statusmemb.DataPropertyName = "Status";
            Statusmemb.HeaderText = "Status";
            Statusmemb.MinimumWidth = 6;
            Statusmemb.Name = "Statusmemb";
            Statusmemb.Width = 125;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1253, 544);
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
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            Trainertab.ResumeLayout(false);
            Trainertab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Paymenttab.ResumeLayout(false);
            Paymenttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            MyPlantab.ResumeLayout(false);
            MyPlantab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            Mypaymenttab.ResumeLayout(false);
            Mypaymenttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            Msplantab.ResumeLayout(false);
            Msplantab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            MsAttendancetab.ResumeLayout(false);
            MsAttendancetab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
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
        private TabPage Msplantab;
        private TabPage MsAttendancetab;
        private TextBox txtboxUsername;
        private Label Title;
        private Button Logoutbtn;
        private Label label5;
        private Button button3;
        private DataGridView dgvPayments;
        private PictureBox pictureBox2;
        private Label label6;
        private DataGridView dgvMembers;
        private Button btnAddMember;
        private Button btnTestConnection;
        private DataGridView dgvTrainers;
        private Button btnAddTrainer;
        private Label label7;
        private DataGridView dgvMPlan;
        private Label label1;
        private Button btnrefreshMplan;
        private DataGridView dgvMyPayment;
        private Label MYPaymentlab;
        private Button btnrefreshMyPay;
        private Button btnDeletePlan;
        private Button btnMsAdd1;
        private Label MsAttendlab1;
        private DataGridView dgvAttendance;
        private Button btnMsAddAttend;
        private PictureBox pictureBox3;
        private Button btnAddAccount;
        private DataGridView dgvPlans;
        private Button btnRefreshPlans;
        private Label Mplaninnglab1;
        private Button Btndelete48;
        private Button btnRefreshMembers;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
        private PictureBox pictureBox12;
        private Button btnDeleteAttendance;
        private Button btnRefreshAttendance;
        private Button refreshtrain2433;
        private Button deletetrainbtn23;
        private Button deletepaybtn21;
        private Button btnRefreshPayments;
        private DataGridViewTextBoxColumn payDate;
        private DataGridViewTextBoxColumn Amount2;
        private DataGridViewTextBoxColumn Description2;
        private DataGridViewTextBoxColumn Planid;
        private DataGridViewTextBoxColumn Memberdi;
        private DataGridViewTextBoxColumn Membersgrid1;
        private DataGridViewTextBoxColumn Durationgrid1;
        private DataGridViewTextBoxColumn Assignedgrid1;
        private DataGridViewButtonColumn Editplan;
        private DataGridViewCheckBoxColumn Deleteplan;
        private DataGridViewTextBoxColumn Statusmembers;
        private DataGridViewTextBoxColumn MemberID;
        private DataGridViewTextBoxColumn Accountdi;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn MemberShipType;
        private DataGridViewButtonColumn Edit;
        private DataGridViewCheckBoxColumn Delete;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Mode;
        private DataGridViewTextBoxColumn TrainerID;
        private DataGridViewTextBoxColumn Accountme;
        private DataGridViewTextBoxColumn Tfirstname;
        private DataGridViewTextBoxColumn Tlastname;
        private DataGridViewTextBoxColumn Tspecialization;
        private DataGridViewButtonColumn Edittrainer;
        private DataGridViewCheckBoxColumn DeleteTrainer;
        private DataGridViewTextBoxColumn StatusTrainer;
        private DataGridViewButtonColumn ModeTrainer;
        private DataGridViewTextBoxColumn Planid1;
        private DataGridViewTextBoxColumn Duration1;
        private DataGridViewTextBoxColumn Trainer;
        private DataGridViewTextBoxColumn Assigned1;
        private DataGridViewTextBoxColumn Attendanceid;
        private DataGridViewTextBoxColumn MsMemberId;
        private DataGridViewTextBoxColumn MsName13;
        private DataGridViewTextBoxColumn Date13;
        private DataGridViewTextBoxColumn Status13;
        private DataGridViewButtonColumn Editattend;
        private DataGridViewCheckBoxColumn Deleteattend;
        private DataGridViewTextBoxColumn Paymentid;
        private DataGridViewTextBoxColumn Memberdd;
        private DataGridViewTextBoxColumn Pmember;
        private DataGridViewTextBoxColumn PaymentDate;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewButtonColumn Editpayment;
        private DataGridViewCheckBoxColumn Deletepayment;
        private DataGridViewTextBoxColumn Statusmemb;
    }
}
