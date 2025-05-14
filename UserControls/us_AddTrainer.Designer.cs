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
            TPhonelab1 = new Label();
            HireDatelab73 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSaveTrain32 = new Button();
            btnDeletetrain23 = new Button();
            btnClosetrain34 = new Button();
            button3 = new Button();
            trainermanalab254 = new Label();
            SuspendLayout();
            // 
            // Trainerlab1
            // 
            Trainerlab1.AutoSize = true;
            Trainerlab1.Location = new Point(42, 57);
            Trainerlab1.Name = "Trainerlab1";
            Trainerlab1.Size = new Size(100, 20);
            Trainerlab1.TabIndex = 0;
            Trainerlab1.Text = "Trainer-Name";
            // 
            // Specialitylab45
            // 
            Specialitylab45.AutoSize = true;
            Specialitylab45.Location = new Point(69, 114);
            Specialitylab45.Name = "Specialitylab45";
            Specialitylab45.Size = new Size(73, 20);
            Specialitylab45.TabIndex = 1;
            Specialitylab45.Text = "Speciality";
            // 
            // TPhonelab1
            // 
            TPhonelab1.AutoSize = true;
            TPhonelab1.Location = new Point(69, 170);
            TPhonelab1.Name = "TPhonelab1";
            TPhonelab1.Size = new Size(64, 20);
            TPhonelab1.TabIndex = 2;
            TPhonelab1.Text = "T-Phone";
            TPhonelab1.Click += label3_Click;
            // 
            // HireDatelab73
            // 
            HireDatelab73.AutoSize = true;
            HireDatelab73.Location = new Point(67, 231);
            HireDatelab73.Name = "HireDatelab73";
            HireDatelab73.Size = new Size(75, 20);
            HireDatelab73.TabIndex = 3;
            HireDatelab73.Text = "Hire-Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 27);
            textBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(146, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // btnSaveTrain32
            // 
            btnSaveTrain32.BackColor = Color.Red;
            btnSaveTrain32.ForeColor = Color.White;
            btnSaveTrain32.Location = new Point(76, 290);
            btnSaveTrain32.Name = "btnSaveTrain32";
            btnSaveTrain32.Size = new Size(94, 38);
            btnSaveTrain32.TabIndex = 8;
            btnSaveTrain32.Text = "Save";
            btnSaveTrain32.UseVisualStyleBackColor = false;
            // 
            // btnDeletetrain23
            // 
            btnDeletetrain23.BackColor = Color.FromArgb(0, 0, 192);
            btnDeletetrain23.ForeColor = Color.White;
            btnDeletetrain23.Location = new Point(196, 290);
            btnDeletetrain23.Name = "btnDeletetrain23";
            btnDeletetrain23.Size = new Size(94, 38);
            btnDeletetrain23.TabIndex = 9;
            btnDeletetrain23.Text = "Delete";
            btnDeletetrain23.UseVisualStyleBackColor = false;
            // 
            // btnClosetrain34
            // 
            btnClosetrain34.BackColor = Color.Green;
            btnClosetrain34.ForeColor = Color.White;
            btnClosetrain34.Location = new Point(333, 290);
            btnClosetrain34.Name = "btnClosetrain34";
            btnClosetrain34.Size = new Size(94, 38);
            btnClosetrain34.TabIndex = 10;
            btnClosetrain34.Text = "Close";
            btnClosetrain34.UseVisualStyleBackColor = false;
            btnClosetrain34.Click += btnClosetrain34_Click;
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
            // us_AddTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(trainermanalab254);
            Controls.Add(button3);
            Controls.Add(btnClosetrain34);
            Controls.Add(btnDeletetrain23);
            Controls.Add(btnSaveTrain32);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(HireDatelab73);
            Controls.Add(TPhonelab1);
            Controls.Add(Specialitylab45);
            Controls.Add(Trainerlab1);
            Name = "us_AddTrainer";
            Size = new Size(500, 367);
            MouseDown += us_AddTrainer_MouseDown;
            MouseMove += us_AddTrainer_MouseMove;
            MouseUp += us_AddTrainer_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Trainerlab1;
        private Label Specialitylab45;
        private Label TPhonelab1;
        private Label HireDatelab73;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button btnSaveTrain32;
        private Button btnDeletetrain23;
        private Button btnClosetrain34;
        private Button button3;
        private Label trainermanalab254;
    }
}
