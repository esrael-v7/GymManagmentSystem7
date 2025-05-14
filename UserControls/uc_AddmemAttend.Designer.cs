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
            cb51 = new ComboBox();
            dtp3 = new DateTimePicker();
            txtstatus = new TextBox();
            labMsAddAttend7 = new Button();
            labMsDeleteAttend7 = new Button();
            labMsCloseAttend7 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // MSNamelab7
            // 
            MSNamelab7.AutoSize = true;
            MSNamelab7.Location = new Point(33, 73);
            MSNamelab7.Name = "MSNamelab7";
            MSNamelab7.Size = new Size(89, 20);
            MSNamelab7.TabIndex = 0;
            MSNamelab7.Text = "Mem-Name";
            // 
            // MsDateLabel7
            // 
            MsDateLabel7.AutoSize = true;
            MsDateLabel7.Location = new Point(16, 109);
            MsDateLabel7.Name = "MsDateLabel7";
            MsDateLabel7.Size = new Size(106, 20);
            MsDateLabel7.TabIndex = 1;
            MsDateLabel7.Text = "Date of attend";
            // 
            // MsStatuslab7
            // 
            MsStatuslab7.AutoSize = true;
            MsStatuslab7.Location = new Point(33, 145);
            MsStatuslab7.Name = "MsStatuslab7";
            MsStatuslab7.Size = new Size(89, 20);
            MsStatuslab7.TabIndex = 2;
            MsStatuslab7.Text = "Status-mem";
            // 
            // cb51
            // 
            cb51.FormattingEnabled = true;
            cb51.Location = new Point(128, 70);
            cb51.Name = "cb51";
            cb51.Size = new Size(151, 28);
            cb51.TabIndex = 3;
            // 
            // dtp3
            // 
            dtp3.Location = new Point(128, 104);
            dtp3.Name = "dtp3";
            dtp3.Size = new Size(250, 27);
            dtp3.TabIndex = 4;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(128, 142);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(206, 27);
            txtstatus.TabIndex = 5;
            // 
            // labMsAddAttend7
            // 
            labMsAddAttend7.BackColor = Color.Red;
            labMsAddAttend7.ForeColor = Color.White;
            labMsAddAttend7.Location = new Point(37, 198);
            labMsAddAttend7.Name = "labMsAddAttend7";
            labMsAddAttend7.Size = new Size(94, 29);
            labMsAddAttend7.TabIndex = 6;
            labMsAddAttend7.Text = "Add attend";
            labMsAddAttend7.UseVisualStyleBackColor = false;
            // 
            // labMsDeleteAttend7
            // 
            labMsDeleteAttend7.BackColor = Color.FromArgb(0, 0, 192);
            labMsDeleteAttend7.ForeColor = Color.White;
            labMsDeleteAttend7.Location = new Point(139, 198);
            labMsDeleteAttend7.Name = "labMsDeleteAttend7";
            labMsDeleteAttend7.Size = new Size(120, 29);
            labMsDeleteAttend7.TabIndex = 7;
            labMsDeleteAttend7.Text = "Delete attend";
            labMsDeleteAttend7.UseVisualStyleBackColor = false;
            // 
            // labMsCloseAttend7
            // 
            labMsCloseAttend7.BackColor = Color.FromArgb(0, 192, 0);
            labMsCloseAttend7.ForeColor = Color.White;
            labMsCloseAttend7.Location = new Point(269, 198);
            labMsCloseAttend7.Name = "labMsCloseAttend7";
            labMsCloseAttend7.Size = new Size(116, 29);
            labMsCloseAttend7.TabIndex = 8;
            labMsCloseAttend7.Text = "Close attend";
            labMsCloseAttend7.UseVisualStyleBackColor = false;
            labMsCloseAttend7.Click += labMsCloseAttend7_Click;
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
            // uc_AddmemAttend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(labMsCloseAttend7);
            Controls.Add(labMsDeleteAttend7);
            Controls.Add(labMsAddAttend7);
            Controls.Add(txtstatus);
            Controls.Add(dtp3);
            Controls.Add(cb51);
            Controls.Add(MsStatuslab7);
            Controls.Add(MsDateLabel7);
            Controls.Add(MSNamelab7);
            Name = "uc_AddmemAttend";
            Size = new Size(415, 246);
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
        private ComboBox cb51;
        private DateTimePicker dtp3;
        private TextBox txtstatus;
        private Button labMsAddAttend7;
        private Button labMsDeleteAttend7;
        private Button labMsCloseAttend7;
        private Label label1;
        private Button button3;
    }
}
