namespace GymManagmentSystem7.UserControls
{
    partial class ucAddPayment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        // Add this method to the ucAddPayment class
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Delete payment button clicked.");
        }
      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            MessageBox.Show("Selected index changed in CB12.");
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("Date value changed.");
        }
       
        private void label4_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Payment label clicked.");
        }
      
        private void label1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Member Name label clicked.");
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Amount label clicked.");
        }
   
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("Selected index changed in namelistcombo.");
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Add payment button clicked.");
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show("Text changed in txtAM.");
        }
       
        private void label2_Click(object sender, EventArgs e)
        {
      
            MessageBox.Show("Date label clicked.");
        }
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
            btnD = new Button();
            Amountlab9 = new Label();
            CB12 = new ComboBox();
            txtAM = new TextBox();
            DTP1 = new DateTimePicker();
            namelistcombo = new ComboBox();
            Paymentlab9 = new Label();
            Datelab9 = new Label();
            MemNamelab9 = new Label();
            btnA = new Button();
            btnC = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnD
            // 
            btnD.BackColor = Color.Red;
            btnD.ForeColor = Color.White;
            btnD.Location = new Point(194, 275);
            btnD.Name = "btnD";
            btnD.Size = new Size(128, 42);
            btnD.TabIndex = 21;
            btnD.Text = "Delete payment";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnDelete_Click;
            // 
            // Amountlab9
            // 
            Amountlab9.AutoSize = true;
            Amountlab9.Location = new Point(71, 158);
            Amountlab9.Name = "Amountlab9";
            Amountlab9.Size = new Size(97, 20);
            Amountlab9.TabIndex = 19;
            Amountlab9.Text = "Amount(ETB)";
            Amountlab9.Click += label3_Click;
            // 
            // CB12
            // 
            CB12.FormattingEnabled = true;
            CB12.Location = new Point(212, 203);
            CB12.Name = "CB12";
            CB12.Size = new Size(176, 28);
            CB12.TabIndex = 18;
            CB12.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtAM
            // 
            txtAM.Location = new Point(212, 158);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(176, 27);
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
            namelistcombo.Size = new Size(176, 28);
            namelistcombo.TabIndex = 15;
            namelistcombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Paymentlab9
            // 
            Paymentlab9.AutoSize = true;
            Paymentlab9.Location = new Point(71, 211);
            Paymentlab9.Name = "Paymentlab9";
            Paymentlab9.Size = new Size(90, 20);
            Paymentlab9.TabIndex = 14;
            Paymentlab9.Text = "Payment For";
            Paymentlab9.Click += label4_Click;
            // 
            // Datelab9
            // 
            Datelab9.AutoSize = true;
            Datelab9.Location = new Point(110, 119);
            Datelab9.Name = "Datelab9";
            Datelab9.Size = new Size(41, 20);
            Datelab9.TabIndex = 13;
            Datelab9.Text = "Date";
            Datelab9.Click += label2_Click;
            // 
            // MemNamelab9
            // 
            MemNamelab9.AutoSize = true;
            MemNamelab9.Location = new Point(71, 76);
            MemNamelab9.Name = "MemNamelab9";
            MemNamelab9.Size = new Size(109, 20);
            MemNamelab9.TabIndex = 12;
            MemNamelab9.Text = "Member Name";
            MemNamelab9.Click += label1_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.FromArgb(0, 0, 192);
            btnA.ForeColor = Color.White;
            btnA.Location = new Point(26, 275);
            btnA.Name = "btnA";
            btnA.Size = new Size(129, 42);
            btnA.TabIndex = 22;
            btnA.Text = "Add payment";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnAdd_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(0, 64, 0);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(370, 275);
            btnC.Name = "btnC";
            btnC.Size = new Size(128, 42);
            btnC.TabIndex = 23;
            btnC.Text = "Close payment";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnClose_Click;
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
            // ucAddPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(btnC);
            Controls.Add(btnA);
            Controls.Add(btnD);
            Controls.Add(Amountlab9);
            Controls.Add(CB12);
            Controls.Add(txtAM);
            Controls.Add(DTP1);
            Controls.Add(namelistcombo);
            Controls.Add(Paymentlab9);
            Controls.Add(Datelab9);
            Controls.Add(MemNamelab9);
            Name = "ucAddPayment";
            Size = new Size(526, 360);
            Load += ucAddPayment_Load;
            MouseDown += ucAddPayment_MouseDown;
            MouseMove += ucAddPayment_MouseMove;
            MouseUp += ucAddPayment_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnD;
        private Label Amountlab9;
        private ComboBox CB12;
        private TextBox txtAM;
        private DateTimePicker DTP1;
        private ComboBox namelistcombo;
        private Label Paymentlab9;
        private Label Datelab9;
        private Label MemNamelab9;
        private Button btnA;
        private Button btnC;
        private Label label1;
        private Button button3;
    }
}
