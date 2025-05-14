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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            LNamelab1 = new Label();
            txtLName = new TextBox();
            Memshiplab1 = new Label();
            Memshipcombo1 = new ComboBox();
            MIDlab1 = new Label();
            txtMID1 = new TextBox();
            SuspendLayout();
            // 
            // Fnamelab1
            // 
            Fnamelab1.AutoSize = true;
            Fnamelab1.Location = new Point(3, 111);
            Fnamelab1.Name = "Fnamelab1";
            Fnamelab1.Size = new Size(62, 20);
            Fnamelab1.TabIndex = 0;
            Fnamelab1.Text = "F-Name";
            // 
            // Agelab1
            // 
            Agelab1.AutoSize = true;
            Agelab1.Location = new Point(16, 202);
            Agelab1.Name = "Agelab1";
            Agelab1.Size = new Size(36, 20);
            Agelab1.TabIndex = 1;
            Agelab1.Text = "Age";
            // 
            // Genderlab1
            // 
            Genderlab1.AutoSize = true;
            Genderlab1.Location = new Point(287, 63);
            Genderlab1.Name = "Genderlab1";
            Genderlab1.Size = new Size(57, 20);
            Genderlab1.TabIndex = 2;
            Genderlab1.Text = "Gender";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(84, 104);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(136, 27);
            txtFname.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(84, 195);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(136, 27);
            txtAge.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(380, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(143, 261);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 192);
            button2.ForeColor = Color.White;
            button2.Location = new Point(307, 261);
            button2.Name = "button2";
            button2.Size = new Size(103, 42);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            LNamelab1.Location = new Point(3, 155);
            LNamelab1.Name = "LNamelab1";
            LNamelab1.Size = new Size(62, 20);
            LNamelab1.TabIndex = 14;
            LNamelab1.Text = "L-Name";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(84, 152);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(136, 27);
            txtLName.TabIndex = 15;
            // 
            // Memshiplab1
            // 
            Memshiplab1.AutoSize = true;
            Memshiplab1.Location = new Point(243, 106);
            Memshiplab1.Name = "Memshiplab1";
            Memshiplab1.Size = new Size(131, 20);
            Memshiplab1.TabIndex = 16;
            Memshiplab1.Text = "MemberShip-Type";
            // 
            // Memshipcombo1
            // 
            Memshipcombo1.FormattingEnabled = true;
            Memshipcombo1.Location = new Point(380, 103);
            Memshipcombo1.Name = "Memshipcombo1";
            Memshipcombo1.Size = new Size(151, 28);
            Memshipcombo1.TabIndex = 17;
            // 
            // MIDlab1
            // 
            MIDlab1.AutoSize = true;
            MIDlab1.Location = new Point(15, 63);
            MIDlab1.Name = "MIDlab1";
            MIDlab1.Size = new Size(43, 20);
            MIDlab1.TabIndex = 18;
            MIDlab1.Text = "M-ID";
            // 
            // txtMID1
            // 
            txtMID1.Location = new Point(84, 60);
            txtMID1.Name = "txtMID1";
            txtMID1.Size = new Size(136, 27);
            txtMID1.TabIndex = 19;
            // 
            // uc_AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtMID1);
            Controls.Add(MIDlab1);
            Controls.Add(Memshipcombo1);
            Controls.Add(Memshiplab1);
            Controls.Add(txtLName);
            Controls.Add(LNamelab1);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label6;
        private Button button3;
        private Label LNamelab1;
        private TextBox txtLName;
        private Label Memshiplab1;
        private ComboBox Memshipcombo1;
        private Label MIDlab1;
        private TextBox txtMID1;
    }
}
