namespace GymManagmentSystem7.UserControls
{
    partial class us_AddTrainer
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
            Trainerlab1 = new Label();
            Specialitylab45 = new Label();
            TLastnamelab48 = new Label();
            txtTfirstname = new TextBox();
            txtTlastname = new TextBox();
            btnSaveTrain32 = new Button();
            button3 = new Button();
            trainermanalab254 = new Label();
            btnupdatetrain90 = new Button();
            cmbSpecialization = new ComboBox();
            SuspendLayout();
            // 
            // Trainerlab1
            // 
            Trainerlab1.AutoSize = true;
            Trainerlab1.Location = new Point(42, 57);
            Trainerlab1.Name = "Trainerlab1";
            Trainerlab1.Size = new Size(76, 20);
            Trainerlab1.TabIndex = 0;
            Trainerlab1.Text = "FirstName";
            // 
            // Specialitylab45
            // 
            Specialitylab45.AutoSize = true;
            Specialitylab45.Location = new Point(27, 174);
            Specialitylab45.Name = "Specialitylab45";
            Specialitylab45.Size = new Size(102, 20);
            Specialitylab45.TabIndex = 1;
            Specialitylab45.Text = "Specialization";
            // 
            // TLastnamelab48
            // 
            TLastnamelab48.AutoSize = true;
            TLastnamelab48.Location = new Point(42, 118);
            TLastnamelab48.Name = "TLastnamelab48";
            TLastnamelab48.Size = new Size(75, 20);
            TLastnamelab48.TabIndex = 2;
            TLastnamelab48.Text = "LastName";
            TLastnamelab48.Click += label3_Click;
            // 
            // txtTfirstname
            // 
            txtTfirstname.Location = new Point(146, 54);
            txtTfirstname.Name = "txtTfirstname";
            txtTfirstname.Size = new Size(237, 27);
            txtTfirstname.TabIndex = 4;
            // 
            // txtTlastname
            // 
            txtTlastname.Location = new Point(146, 111);
            txtTlastname.Name = "txtTlastname";
            txtTlastname.Size = new Size(237, 27);
            txtTlastname.TabIndex = 6;
            // 
            // btnSaveTrain32
            // 
            btnSaveTrain32.BackColor = Color.Red;
            btnSaveTrain32.ForeColor = Color.White;
            btnSaveTrain32.Location = new Point(77, 237);
            btnSaveTrain32.Name = "btnSaveTrain32";
            btnSaveTrain32.Size = new Size(94, 38);
            btnSaveTrain32.TabIndex = 8;
            btnSaveTrain32.Text = "Save";
            btnSaveTrain32.UseVisualStyleBackColor = false;
            btnSaveTrain32.Click += btnSaveTrain32_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(451, 12);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 27;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // trainermanalab254
            // 
            trainermanalab254.AutoSize = true;
            trainermanalab254.BackColor = Color.FromArgb(64, 0, 0);
            trainermanalab254.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trainermanalab254.ForeColor = Color.White;
            trainermanalab254.Location = new Point(184, 9);
            trainermanalab254.Name = "trainermanalab254";
            trainermanalab254.Size = new Size(97, 27);
            trainermanalab254.TabIndex = 28;
            trainermanalab254.Text = "Trainers";
            // 
            // btnupdatetrain90
            // 
            btnupdatetrain90.BackColor = Color.FromArgb(0, 64, 64);
            btnupdatetrain90.ForeColor = Color.White;
            btnupdatetrain90.Location = new Point(276, 237);
            btnupdatetrain90.Name = "btnupdatetrain90";
            btnupdatetrain90.Size = new Size(94, 38);
            btnupdatetrain90.TabIndex = 29;
            btnupdatetrain90.Text = "Update";
            btnupdatetrain90.UseVisualStyleBackColor = false;
            btnupdatetrain90.Click += btnupdatetrain90_Click;
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.Location = new Point(146, 166);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(237, 28);
            cmbSpecialization.TabIndex = 30;
            // 
            // us_AddTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbSpecialization);
            Controls.Add(btnupdatetrain90);
            Controls.Add(trainermanalab254);
            Controls.Add(button3);
            Controls.Add(btnSaveTrain32);
            Controls.Add(txtTlastname);
            Controls.Add(txtTfirstname);
            Controls.Add(TLastnamelab48);
            Controls.Add(Specialitylab45);
            Controls.Add(Trainerlab1);
            Name = "us_AddTrainer";
            Size = new Size(500, 298);
            Load += us_AddTrainer_Load;
            MouseDown += us_AddTrainer_MouseDown;
            MouseMove += us_AddTrainer_MouseMove;
            MouseUp += us_AddTrainer_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Trainerlab1;
        private Label Specialitylab45;
        private Label TLastnamelab48;
        private TextBox txtTfirstname;
        private TextBox txtTlastname;
        private Button btnSaveTrain32;
        private Button button3;
        private Label trainermanalab254;
        private Button btnupdatetrain90;
        private ComboBox cmbSpecialization;
    }
}
