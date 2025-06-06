namespace GymManagmentSystem7.UserControls
{
    partial class uc_AddmemAttend
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
            MSNamelab7 = new Label();
            MsDateLabel7 = new Label();
            MsStatuslab7 = new Label();
            cmbMember84 = new ComboBox();
            dtpDate84 = new DateTimePicker();
            labMsAddAttend7 = new Button();
            label1 = new Label();
            button3 = new Button();
            Updateattendbtn11 = new Button();
            cmbStatus84 = new ComboBox();
            SuspendLayout();
            // 
            // MSNamelab7
            // 
            MSNamelab7.AutoSize = true;
            MSNamelab7.Location = new Point(33, 73);
            MSNamelab7.Name = "MSNamelab7";
            MSNamelab7.Size = new Size(65, 20);
            MSNamelab7.TabIndex = 0;
            MSNamelab7.Text = "Member";
            // 
            // MsDateLabel7
            // 
            MsDateLabel7.AutoSize = true;
            MsDateLabel7.Location = new Point(45, 111);
            MsDateLabel7.Name = "MsDateLabel7";
            MsDateLabel7.Size = new Size(41, 20);
            MsDateLabel7.TabIndex = 1;
            MsDateLabel7.Text = "Date";
            // 
            // MsStatuslab7
            // 
            MsStatuslab7.AutoSize = true;
            MsStatuslab7.Location = new Point(45, 148);
            MsStatuslab7.Name = "MsStatuslab7";
            MsStatuslab7.Size = new Size(49, 20);
            MsStatuslab7.TabIndex = 2;
            MsStatuslab7.Text = "Status";
            // 
            // cmbMember84
            // 
            cmbMember84.FormattingEnabled = true;
            cmbMember84.Location = new Point(128, 70);
            cmbMember84.Name = "cmbMember84";
            cmbMember84.Size = new Size(250, 28);
            cmbMember84.TabIndex = 3;
            // 
            // dtpDate84
            // 
            dtpDate84.Location = new Point(128, 104);
            dtpDate84.Name = "dtpDate84";
            dtpDate84.Size = new Size(250, 27);
            dtpDate84.TabIndex = 4;
            // 
            // labMsAddAttend7
            // 
            labMsAddAttend7.BackColor = Color.Red;
            labMsAddAttend7.ForeColor = Color.White;
            labMsAddAttend7.Location = new Point(90, 186);
            labMsAddAttend7.Name = "labMsAddAttend7";
            labMsAddAttend7.Size = new Size(94, 43);
            labMsAddAttend7.TabIndex = 6;
            labMsAddAttend7.Text = "Add attend";
            labMsAddAttend7.UseVisualStyleBackColor = false;
            labMsAddAttend7.Click += labMsAddAttend7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 9;
            label1.Text = "Attendance";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(375, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 26;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Updateattendbtn11
            // 
            Updateattendbtn11.BackColor = Color.Navy;
            Updateattendbtn11.ForeColor = Color.White;
            Updateattendbtn11.Location = new Point(257, 186);
            Updateattendbtn11.Name = "Updateattendbtn11";
            Updateattendbtn11.Size = new Size(94, 43);
            Updateattendbtn11.TabIndex = 27;
            Updateattendbtn11.Text = "Update ";
            Updateattendbtn11.UseVisualStyleBackColor = false;
            Updateattendbtn11.Click += Updateattendbtn11_Click;
            // 
            // cmbStatus84
            // 
            cmbStatus84.FormattingEnabled = true;
            cmbStatus84.Location = new Point(128, 140);
            cmbStatus84.Name = "cmbStatus84";
            cmbStatus84.Size = new Size(250, 28);
            cmbStatus84.TabIndex = 28;
            // 
            // uc_AddmemAttend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbStatus84);
            Controls.Add(Updateattendbtn11);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(labMsAddAttend7);
            Controls.Add(dtpDate84);
            Controls.Add(cmbMember84);
            Controls.Add(MsStatuslab7);
            Controls.Add(MsDateLabel7);
            Controls.Add(MSNamelab7);
            Name = "uc_AddmemAttend";
            Size = new Size(415, 246);
            Load += uc_AddmemAttend_Load;
            MouseDown += uc_AddmemAttend_MouseDown;
            MouseMove += uc_AddmemAttend_MouseMove;
            MouseUp += uc_AddmemAttend_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MSNamelab7;
        private Label MsDateLabel7;
        private Label MsStatuslab7;
        private ComboBox cmbMember84;
        private DateTimePicker dtpDate84;
        private Button labMsAddAttend7;
        private Label label1;
        private Button button3;
        private Button Updateattendbtn11;
        private ComboBox cmbStatus84;
    }
}
