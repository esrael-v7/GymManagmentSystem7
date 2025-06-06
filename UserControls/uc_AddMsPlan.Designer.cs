namespace GymManagmentSystem7.UserControls
{
    partial class uc_AddMsPlan
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
            MsPLanlab11 = new Label();
            updabtn = new Button();
            button3 = new Button();
            memberlab2 = new Label();
            durationlab2 = new Label();
            datelab2 = new Label();
            cmbmember4 = new ComboBox();
            nudduration2 = new NumericUpDown();
            dtpdate2 = new DateTimePicker();
            btnaddmemb2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudduration2).BeginInit();
            SuspendLayout();
            // 
            // MsPLanlab11
            // 
            MsPLanlab11.AutoSize = true;
            MsPLanlab11.BackColor = Color.Navy;
            MsPLanlab11.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MsPLanlab11.Location = new Point(175, 39);
            MsPLanlab11.Name = "MsPLanlab11";
            MsPLanlab11.Size = new Size(225, 37);
            MsPLanlab11.TabIndex = 0;
            MsPLanlab11.Text = "Members-Plan";
            // 
            // updabtn
            // 
            updabtn.BackColor = Color.Red;
            updabtn.ForeColor = Color.White;
            updabtn.Location = new Point(118, 113);
            updabtn.Name = "updabtn";
            updabtn.Size = new Size(109, 47);
            updabtn.TabIndex = 3;
            updabtn.Text = "Update";
            updabtn.UseVisualStyleBackColor = false;
            updabtn.Click += updabtn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(548, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 14;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // memberlab2
            // 
            memberlab2.AutoSize = true;
            memberlab2.Font = new Font("Century Gothic", 10.2F);
            memberlab2.ForeColor = Color.Black;
            memberlab2.Location = new Point(81, 203);
            memberlab2.Name = "memberlab2";
            memberlab2.Size = new Size(88, 21);
            memberlab2.TabIndex = 16;
            memberlab2.Text = "Members";
            // 
            // durationlab2
            // 
            durationlab2.AutoSize = true;
            durationlab2.Font = new Font("Century Gothic", 10.2F);
            durationlab2.ForeColor = Color.Black;
            durationlab2.Location = new Point(81, 260);
            durationlab2.Name = "durationlab2";
            durationlab2.Size = new Size(81, 21);
            durationlab2.TabIndex = 17;
            durationlab2.Text = "Duration";
            // 
            // datelab2
            // 
            datelab2.AutoSize = true;
            datelab2.Font = new Font("Century Gothic", 10.2F);
            datelab2.ForeColor = Color.Black;
            datelab2.Location = new Point(42, 333);
            datelab2.Name = "datelab2";
            datelab2.Size = new Size(127, 21);
            datelab2.TabIndex = 18;
            datelab2.Text = "AssignedDate";
            // 
            // cmbmember4
            // 
            cmbmember4.Font = new Font("Century Gothic", 10.2F);
            cmbmember4.FormattingEnabled = true;
            cmbmember4.Location = new Point(185, 200);
            cmbmember4.Name = "cmbmember4";
            cmbmember4.Size = new Size(250, 29);
            cmbmember4.TabIndex = 21;
            // 
            // nudduration2
            // 
            nudduration2.Font = new Font("Century Gothic", 10.2F);
            nudduration2.Location = new Point(185, 260);
            nudduration2.Name = "nudduration2";
            nudduration2.Size = new Size(250, 28);
            nudduration2.TabIndex = 22;
            // 
            // dtpdate2
            // 
            dtpdate2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpdate2.Location = new Point(185, 327);
            dtpdate2.Name = "dtpdate2";
            dtpdate2.Size = new Size(250, 28);
            dtpdate2.TabIndex = 23;
            // 
            // btnaddmemb2
            // 
            btnaddmemb2.BackColor = Color.Teal;
            btnaddmemb2.ForeColor = Color.White;
            btnaddmemb2.Location = new Point(347, 113);
            btnaddmemb2.Name = "btnaddmemb2";
            btnaddmemb2.Size = new Size(111, 47);
            btnaddmemb2.TabIndex = 25;
            btnaddmemb2.Text = "Add";
            btnaddmemb2.UseVisualStyleBackColor = false;
            btnaddmemb2.Click += btnaddmemb2_Click;
            // 
            // uc_AddMsPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnaddmemb2);
            Controls.Add(dtpdate2);
            Controls.Add(nudduration2);
            Controls.Add(cmbmember4);
            Controls.Add(datelab2);
            Controls.Add(durationlab2);
            Controls.Add(memberlab2);
            Controls.Add(button3);
            Controls.Add(updabtn);
            Controls.Add(MsPLanlab11);
            Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "uc_AddMsPlan";
            Size = new Size(588, 427);
            Load += uc_AddMsPlan_Load;
            MouseDown += uc_viewMsPlan_MouseDown;
            MouseMove += uc_viewMsPlan_MouseMove;
            MouseUp += uc_viewMsPlan_MouseUp;
            ((System.ComponentModel.ISupportInitialize)nudduration2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MsPLanlab11;
        private Button updabtn;
        private Button button3;
        private Label memberlab2;
        private Label durationlab2;
        private Label datelab2;
        private ComboBox cmbmember4;
        private NumericUpDown nudduration2;
        private DateTimePicker dtpdate2;
        private Button btnaddmemb2;
    }
}
