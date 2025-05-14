namespace GymManagmentSystem7.UserControls
{
    partial class uc_AddAccount
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
            Accountreglab = new Label();
            UserNamelab1 = new Label();
            Passwordlab1 = new Label();
            Rolelab1 = new Label();
            Statuslab1 = new Label();
            btnCreate1 = new Button();
            txtusername1 = new TextBox();
            txtPassword1 = new TextBox();
            cmbRole1 = new ComboBox();
            cmbStatus1 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // Accountreglab
            // 
            Accountreglab.AutoSize = true;
            Accountreglab.BackColor = Color.FromArgb(192, 0, 0);
            Accountreglab.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Accountreglab.ForeColor = Color.White;
            Accountreglab.Location = new Point(74, 15);
            Accountreglab.Name = "Accountreglab";
            Accountreglab.Size = new Size(322, 37);
            Accountreglab.TabIndex = 0;
            Accountreglab.Text = "Account-Registration";
            // 
            // UserNamelab1
            // 
            UserNamelab1.AutoSize = true;
            UserNamelab1.Location = new Point(74, 81);
            UserNamelab1.Name = "UserNamelab1";
            UserNamelab1.Size = new Size(84, 20);
            UserNamelab1.TabIndex = 1;
            UserNamelab1.Text = "User-Name";
            // 
            // Passwordlab1
            // 
            Passwordlab1.AutoSize = true;
            Passwordlab1.Location = new Point(88, 135);
            Passwordlab1.Name = "Passwordlab1";
            Passwordlab1.Size = new Size(70, 20);
            Passwordlab1.TabIndex = 2;
            Passwordlab1.Text = "Password";
            // 
            // Rolelab1
            // 
            Rolelab1.AutoSize = true;
            Rolelab1.Location = new Point(106, 193);
            Rolelab1.Name = "Rolelab1";
            Rolelab1.Size = new Size(39, 20);
            Rolelab1.TabIndex = 3;
            Rolelab1.Text = "Role";
            // 
            // Statuslab1
            // 
            Statuslab1.AutoSize = true;
            Statuslab1.Location = new Point(106, 254);
            Statuslab1.Name = "Statuslab1";
            Statuslab1.Size = new Size(49, 20);
            Statuslab1.TabIndex = 4;
            Statuslab1.Text = "Status";
            // 
            // btnCreate1
            // 
            btnCreate1.BackColor = Color.FromArgb(0, 0, 192);
            btnCreate1.ForeColor = Color.White;
            btnCreate1.Location = new Point(183, 298);
            btnCreate1.Name = "btnCreate1";
            btnCreate1.Size = new Size(94, 42);
            btnCreate1.TabIndex = 5;
            btnCreate1.Text = "Create";
            btnCreate1.UseVisualStyleBackColor = false;
            // 
            // txtusername1
            // 
            txtusername1.Location = new Point(171, 78);
            txtusername1.Name = "txtusername1";
            txtusername1.Size = new Size(151, 27);
            txtusername1.TabIndex = 6;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(171, 128);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(151, 27);
            txtPassword1.TabIndex = 7;
            // 
            // cmbRole1
            // 
            cmbRole1.FormattingEnabled = true;
            cmbRole1.Location = new Point(171, 185);
            cmbRole1.Name = "cmbRole1";
            cmbRole1.Size = new Size(151, 28);
            cmbRole1.TabIndex = 8;
            // 
            // cmbStatus1
            // 
            cmbStatus1.FormattingEnabled = true;
            cmbStatus1.Location = new Point(171, 246);
            cmbStatus1.Name = "cmbStatus1";
            cmbStatus1.Size = new Size(151, 28);
            cmbStatus1.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(458, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 14;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // uc_AddAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(cmbStatus1);
            Controls.Add(cmbRole1);
            Controls.Add(txtPassword1);
            Controls.Add(txtusername1);
            Controls.Add(btnCreate1);
            Controls.Add(Statuslab1);
            Controls.Add(Rolelab1);
            Controls.Add(Passwordlab1);
            Controls.Add(UserNamelab1);
            Controls.Add(Accountreglab);
            Name = "uc_AddAccount";
            Size = new Size(501, 370);
            MouseDown += uc_AddAccount_MouseDown;
            MouseMove += uc_AddAccount_MouseMove;
            MouseUp += uc_AddAccount_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Accountreglab;
        private Label UserNamelab1;
        private Label Passwordlab1;
        private Label Rolelab1;
        private Label Statuslab1;
        private Button btnCreate1;
        private TextBox txtusername1;
        private TextBox txtPassword1;
        private ComboBox cmbRole1;
        private ComboBox cmbStatus1;
        private Button button3;
    }
}
