namespace GymManagmentSystem7.UserControls
{
    partial class uc_AddPayment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        // Add this method to the ucAddPayment class
     
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
            Amountlab9 = new Label();
            txtAM = new TextBox();
            DTP1 = new DateTimePicker();
            namelistcombo = new ComboBox();
            Datelab9 = new Label();
            MemNamelab9 = new Label();
            btnA = new Button();
            label1 = new Label();
            button3 = new Button();
            btnupdatepayment464 = new Button();
            SuspendLayout();
            // 
            // Amountlab9
            // 
            Amountlab9.AutoSize = true;
            Amountlab9.Location = new Point(99, 158);
            Amountlab9.Name = "Amountlab9";
            Amountlab9.Size = new Size(62, 20);
            Amountlab9.TabIndex = 19;
            Amountlab9.Text = "Amount";
            Amountlab9.Click += label3_Click;
            // 
            // txtAM
            // 
            txtAM.Location = new Point(212, 158);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(261, 27);
            txtAM.TabIndex = 17;
            txtAM.TextChanged += textBox1_TextChanged;
            // 
            // DTP1
            // 
            DTP1.Location = new Point(212, 114);
            DTP1.Name = "DTP1";
            DTP1.Size = new Size(261, 27);
            DTP1.TabIndex = 16;
            DTP1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // namelistcombo
            // 
            namelistcombo.FormattingEnabled = true;
            namelistcombo.Location = new Point(212, 73);
            namelistcombo.Name = "namelistcombo";
            namelistcombo.Size = new Size(261, 28);
            namelistcombo.TabIndex = 15;
            namelistcombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Datelab9
            // 
            Datelab9.AutoSize = true;
            Datelab9.Location = new Point(82, 119);
            Datelab9.Name = "Datelab9";
            Datelab9.Size = new Size(97, 20);
            Datelab9.TabIndex = 13;
            Datelab9.Text = "PaymentDate";
            Datelab9.Click += label2_Click;
            // 
            // MemNamelab9
            // 
            MemNamelab9.AutoSize = true;
            MemNamelab9.Location = new Point(99, 76);
            MemNamelab9.Name = "MemNamelab9";
            MemNamelab9.Size = new Size(69, 20);
            MemNamelab9.TabIndex = 12;
            MemNamelab9.Text = "Member ";
            MemNamelab9.Click += label1_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(0, 0, 192);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(99, 201);
            btnA.Name = "btnA";
            btnA.Size = new Size(129, 42);
            btnA.TabIndex = 22;
            btnA.Text = "Add payment";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(182, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 24;
            label1.Text = "Payment";
            label1.Click += label1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(486, 3);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 25;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnupdatepayment464
            // 
            btnupdatepayment464.BackColor = Color.Maroon;
            btnupdatepayment464.ForeColor = Color.White;
            btnupdatepayment464.Location = new Point(333, 201);
            btnupdatepayment464.Name = "btnupdatepayment464";
            btnupdatepayment464.Size = new Size(129, 42);
            btnupdatepayment464.TabIndex = 26;
            btnupdatepayment464.Text = "Update payment";
            btnupdatepayment464.UseVisualStyleBackColor = false;
            btnupdatepayment464.Click += this.btnupdatepayment464_Click;
            // 
            // uc_AddPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnupdatepayment464);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(btnA);
            Controls.Add(Amountlab9);
            Controls.Add(txtAM);
            Controls.Add(DTP1);
            Controls.Add(namelistcombo);
            Controls.Add(Datelab9);
            Controls.Add(MemNamelab9);
            Name = "uc_AddPayment";
            Size = new Size(526, 261);
            Load += uc_AddPayment_Load;
            MouseDown += uc_AddPayment_MouseDown;
            MouseMove += uc_AddPayment_MouseMove;
            MouseUp += uc_AddPayment_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Amountlab9;
        private TextBox txtAM;
        private DateTimePicker DTP1;
        private ComboBox namelistcombo;
        private Label Datelab9;
        private Label MemNamelab9;
        private Button btnA;
        private Label label1;
        private Button button3;
        private Button btnupdatepayment464;
    }
}
