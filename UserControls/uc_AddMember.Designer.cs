namespace GymManagmentSystem7.UserControls
{
    partial class uc_AddMember
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Fnamelab1 = new Label();
            Agelab1 = new Label();
            Genderlab1 = new Label();
            txtFname = new TextBox();
            txtAge = new TextBox();
            cmbgend48 = new ComboBox();
            label6 = new Label();
            button3 = new Button();
            LNamelab1 = new Label();
            txtLName = new TextBox();
            Memshiplab1 = new Label();
            Memshipcombo1 = new ComboBox();
            btnsave39 = new Button();
            Btnupdate48 = new Button();
            usernamelab1 = new Label();
            passwordlab1 = new Label();
            txtusername48 = new TextBox();
            txtpassword48 = new TextBox();
            dtpage25 = new DateTimePicker();
            SuspendLayout();
            // 
            // Fnamelab1
            // 
            Fnamelab1.AutoSize = true;
            Fnamelab1.Location = new Point(14, 63);
            Fnamelab1.Name = "Fnamelab1";
            Fnamelab1.Size = new Size(76, 20);
            Fnamelab1.TabIndex = 0;
            Fnamelab1.Text = "FirstName";
            // 
            // Agelab1
            // 
            Agelab1.AutoSize = true;
            Agelab1.Location = new Point(14, 173);
            Agelab1.Name = "Agelab1";
            Agelab1.Size = new Size(36, 20);
            Agelab1.TabIndex = 1;
            Agelab1.Text = "Age";
            // 
            // Genderlab1
            // 
            Genderlab1.AutoSize = true;
            Genderlab1.Location = new Point(287, 70);
            Genderlab1.Name = "Genderlab1";
            Genderlab1.Size = new Size(57, 20);
            Genderlab1.TabIndex = 2;
            Genderlab1.Text = "Gender";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(96, 63);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(136, 27);
            txtFname.TabIndex = 5;
            txtFname.TextChanged += txtFname_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(56, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(34, 27);
            txtAge.TabIndex = 6;
            // 
            // cmbgend48
            // 
            cmbgend48.FormattingEnabled = true;
            cmbgend48.Location = new Point(380, 60);
            cmbgend48.Name = "cmbgend48";
            cmbgend48.Size = new Size(151, 28);
            cmbgend48.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(213, 14);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 12;
            label6.Text = "Add_Member";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(496, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 13;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // LNamelab1
            // 
            LNamelab1.AutoSize = true;
            LNamelab1.Location = new Point(15, 120);
            LNamelab1.Name = "LNamelab1";
            LNamelab1.Size = new Size(75, 20);
            LNamelab1.TabIndex = 14;
            LNamelab1.Text = "LastName";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(96, 117);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(136, 27);
            txtLName.TabIndex = 15;
            // 
            // Memshiplab1
            // 
            Memshiplab1.AutoSize = true;
            Memshiplab1.Location = new Point(238, 117);
            Memshiplab1.Name = "Memshiplab1";
            Memshiplab1.Size = new Size(125, 20);
            Memshiplab1.TabIndex = 16;
            Memshiplab1.Text = "MemberShipType";
            // 
            // Memshipcombo1
            // 
            Memshipcombo1.FormattingEnabled = true;
            Memshipcombo1.Location = new Point(380, 112);
            Memshipcombo1.Name = "Memshipcombo1";
            Memshipcombo1.Size = new Size(151, 28);
            Memshipcombo1.TabIndex = 17;
            // 
            // btnsave39
            // 
            btnsave39.BackColor = Color.Red;
            btnsave39.ForeColor = Color.White;
            btnsave39.Location = new Point(122, 261);
            btnsave39.Name = "btnsave39";
            btnsave39.Size = new Size(110, 42);
            btnsave39.TabIndex = 20;
            btnsave39.Text = "Save";
            btnsave39.UseVisualStyleBackColor = false;
            btnsave39.Click += btnsave39_Click;
            // 
            // Btnupdate48
            // 
            Btnupdate48.BackColor = Color.FromArgb(64, 64, 0);
            Btnupdate48.ForeColor = Color.White;
            Btnupdate48.Location = new Point(319, 261);
            Btnupdate48.Name = "Btnupdate48";
            Btnupdate48.Size = new Size(110, 42);
            Btnupdate48.TabIndex = 25;
            Btnupdate48.Text = "Update";
            Btnupdate48.UseVisualStyleBackColor = false;
            Btnupdate48.Click += Btnupdate48_Click;
            // 
            // usernamelab1
            // 
            usernamelab1.AutoSize = true;
            usernamelab1.Location = new Point(292, 160);
            usernamelab1.Name = "usernamelab1";
            usernamelab1.Size = new Size(75, 20);
            usernamelab1.TabIndex = 26;
            usernamelab1.Text = "Username";
            // 
            // passwordlab1
            // 
            passwordlab1.AutoSize = true;
            passwordlab1.Location = new Point(292, 198);
            passwordlab1.Name = "passwordlab1";
            passwordlab1.Size = new Size(70, 20);
            passwordlab1.TabIndex = 27;
            passwordlab1.Text = "Password";
            // 
            // txtusername48
            // 
            txtusername48.Location = new Point(380, 153);
            txtusername48.Name = "txtusername48";
            txtusername48.Size = new Size(151, 27);
            txtusername48.TabIndex = 28;
            // 
            // txtpassword48
            // 
            txtpassword48.Location = new Point(380, 191);
            txtpassword48.Name = "txtpassword48";
            txtpassword48.Size = new Size(151, 27);
            txtpassword48.TabIndex = 29;
            // 
            // dtpage25
            // 
            dtpage25.Location = new Point(98, 170);
            dtpage25.Name = "dtpage25";
            dtpage25.Size = new Size(165, 27);
            dtpage25.TabIndex = 30;
            dtpage25.ValueChanged += dtpage25_ValueChanged;
            // 
            // uc_AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpage25);
            Controls.Add(txtpassword48);
            Controls.Add(txtusername48);
            Controls.Add(passwordlab1);
            Controls.Add(usernamelab1);
            Controls.Add(Btnupdate48);
            Controls.Add(btnsave39);
            Controls.Add(Memshipcombo1);
            Controls.Add(Memshiplab1);
            Controls.Add(txtLName);
            Controls.Add(LNamelab1);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(cmbgend48);
            Controls.Add(txtAge);
            Controls.Add(txtFname);
            Controls.Add(Genderlab1);
            Controls.Add(Agelab1);
            Controls.Add(Fnamelab1);
            Name = "uc_AddMember";
            Size = new Size(539, 333);
            Load += uc_AddMember_Load;
            MouseDown += uc_AddMember_MouseDown;
            MouseMove += uc_AddMember_MouseMove;
            MouseUp += uc_AddMember_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Fnamelab1;
        private Label Agelab1;
        private Label Genderlab1;
        private TextBox txtFname;
        private TextBox txtAge;
        private ComboBox cmbgend48;
        private Label label6;
        private Button button3;
        private Label LNamelab1;
        private TextBox txtLName;
        private Label Memshiplab1;
        private ComboBox Memshipcombo1;
        private Button btnsave39;
        private Button Btnupdate48;
        private Label usernamelab1;
        private Label passwordlab1;
        private TextBox txtusername48;
        private TextBox txtpassword48;
        private DateTimePicker dtpage25;
    }
}
