namespace GymManagmentSystem7.UserControls
{
    partial class uc_viewMsPlan
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
            dataGridView1 = new DataGridView();
            PlanName12 = new DataGridViewTextBoxColumn();
            Memeber12 = new DataGridViewTextBoxColumn();
            Duration12 = new DataGridViewTextBoxColumn();
            Date12 = new DataGridViewTextBoxColumn();
            Assign12 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MsPLanlab11
            // 
            MsPLanlab11.AutoSize = true;
            MsPLanlab11.BackColor = Color.Navy;
            MsPLanlab11.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MsPLanlab11.Location = new Point(200, 36);
            MsPLanlab11.Name = "MsPLanlab11";
            MsPLanlab11.Size = new Size(225, 37);
            MsPLanlab11.TabIndex = 0;
            MsPLanlab11.Text = "Members-Plan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PlanName12, Memeber12, Duration12, Date12, Assign12 });
            dataGridView1.Location = new Point(3, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(652, 163);
            dataGridView1.TabIndex = 1;
            // 
            // PlanName12
            // 
            PlanName12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PlanName12.HeaderText = "Plan-Name";
            PlanName12.MinimumWidth = 6;
            PlanName12.Name = "PlanName12";
            // 
            // Memeber12
            // 
            Memeber12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Memeber12.HeaderText = "Memebers";
            Memeber12.MinimumWidth = 6;
            Memeber12.Name = "Memeber12";
            // 
            // Duration12
            // 
            Duration12.HeaderText = "Duration";
            Duration12.MinimumWidth = 6;
            Duration12.Name = "Duration12";
            Duration12.Width = 125;
            // 
            // Date12
            // 
            Date12.HeaderText = "Date";
            Date12.MinimumWidth = 6;
            Date12.Name = "Date12";
            Date12.Width = 125;
            // 
            // Assign12
            // 
            Assign12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Assign12.HeaderText = "Assigned";
            Assign12.MinimumWidth = 6;
            Assign12.Name = "Assign12";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(409, 113);
            button1.Name = "button1";
            button1.Size = new Size(109, 47);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(107, 113);
            button2.Name = "button2";
            button2.Size = new Size(109, 47);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(618, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 14;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // uc_viewMsPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(MsPLanlab11);
            Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Name = "uc_viewMsPlan";
            Size = new Size(658, 336);
            MouseDown += uc_viewMsPlan_MouseDown;
            MouseMove += uc_viewMsPlan_MouseMove;
            MouseUp += uc_viewMsPlan_MouseUp;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MsPLanlab11;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PlanName12;
        private DataGridViewTextBoxColumn Memeber12;
        private DataGridViewTextBoxColumn Duration12;
        private DataGridViewTextBoxColumn Date12;
        private DataGridViewTextBoxColumn Assign12;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
