namespace GymManagmentSystem7.UserControls
{
    partial class uc_ViewMsProgress
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
            label1 = new Label();
            btnupdate8 = new Button();
            btnclose8 = new Button();
            button3 = new Button();
            Notes4 = new DataGridViewTextBoxColumn();
            BodyFat4 = new DataGridViewTextBoxColumn();
            Weight4 = new DataGridViewTextBoxColumn();
            Date4 = new DataGridViewTextBoxColumn();
            MName2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 43);
            label1.Name = "label1";
            label1.Size = new Size(282, 37);
            label1.TabIndex = 0;
            label1.Text = "Members-Progress";
            // 
            // btnupdate8
            // 
            btnupdate8.BackColor = Color.Red;
            btnupdate8.ForeColor = Color.White;
            btnupdate8.Location = new Point(112, 148);
            btnupdate8.Name = "btnupdate8";
            btnupdate8.Size = new Size(109, 47);
            btnupdate8.TabIndex = 5;
            btnupdate8.Text = "Updatepro";
            btnupdate8.UseVisualStyleBackColor = false;
            // 
            // btnclose8
            // 
            btnclose8.BackColor = Color.FromArgb(0, 192, 0);
            btnclose8.ForeColor = Color.White;
            btnclose8.Location = new Point(408, 148);
            btnclose8.Name = "btnclose8";
            btnclose8.Size = new Size(109, 47);
            btnclose8.TabIndex = 4;
            btnclose8.Text = "Closepro";
            btnclose8.UseVisualStyleBackColor = false;
            btnclose8.Click += btnclose8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(608, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 15;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Notes4
            // 
            Notes4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes4.HeaderText = "Notes";
            Notes4.MinimumWidth = 6;
            Notes4.Name = "Notes4";
            // 
            // BodyFat4
            // 
            BodyFat4.HeaderText = "Body Fat(%)";
            BodyFat4.MinimumWidth = 6;
            BodyFat4.Name = "BodyFat4";
            BodyFat4.Width = 125;
            // 
            // Weight4
            // 
            Weight4.HeaderText = "Weight(kg) ";
            Weight4.MinimumWidth = 6;
            Weight4.Name = "Weight4";
            Weight4.Width = 125;
            // 
            // Date4
            // 
            Date4.HeaderText = "Date";
            Date4.MinimumWidth = 6;
            Date4.Name = "Date4";
            Date4.Width = 125;
            // 
            // MName2
            // 
            MName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MName2.HeaderText = "M-Name";
            MName2.MinimumWidth = 6;
            MName2.Name = "MName2";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MName2, Date4, Weight4, BodyFat4, Notes4 });
            dataGridView1.Location = new Point(3, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 167);
            dataGridView1.TabIndex = 1;
            // 
            // uc_ViewMsProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(btnupdate8);
            Controls.Add(btnclose8);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "uc_ViewMsProgress";
            Size = new Size(646, 372);
            MouseDown += uc_ViewMsProgress_MouseDown;
            MouseMove += uc_ViewMsProgress_MouseMove;
            MouseUp += uc_ViewMsProgress_MouseUp;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnupdate8;
        private Button btnclose8;
        private Button button3;
        private DataGridViewTextBoxColumn Notes4;
        private DataGridViewTextBoxColumn BodyFat4;
        private DataGridViewTextBoxColumn Weight4;
        private DataGridViewTextBoxColumn Date4;
        private DataGridViewTextBoxColumn MName2;
        private DataGridView dataGridView1;
    }
}
