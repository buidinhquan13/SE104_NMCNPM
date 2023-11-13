namespace QuanLyQuanCafe
{
    partial class fCheckOut
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSearchCustomerUsername = new Button();
            txbCustomerUsername = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            nmDiscount = new NumericUpDown();
            btnCheckOut = new Button();
            txbFinalPrice = new TextBox();
            txbUsedPoint = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txbTotalPrice = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            btnUnusePoint = new Button();
            btnUsePoint = new Button();
            txbCustomerPoint = new TextBox();
            txbSearchedCustomerUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchCustomerUsername);
            panel1.Controls.Add(txbCustomerUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(303, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 105);
            panel1.TabIndex = 0;
            // 
            // btnSearchCustomerUsername
            // 
            btnSearchCustomerUsername.Location = new Point(200, 74);
            btnSearchCustomerUsername.Name = "btnSearchCustomerUsername";
            btnSearchCustomerUsername.Size = new Size(75, 23);
            btnSearchCustomerUsername.TabIndex = 2;
            btnSearchCustomerUsername.Text = "Tìm kiếm";
            btnSearchCustomerUsername.UseVisualStyleBackColor = true;
            btnSearchCustomerUsername.Click += btnSearchCustomerUsername_Click;
            // 
            // txbCustomerUsername
            // 
            txbCustomerUsername.Location = new Point(3, 45);
            txbCustomerUsername.MaxLength = 20;
            txbCustomerUsername.Name = "txbCustomerUsername";
            txbCustomerUsername.Size = new Size(272, 23);
            txbCustomerUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(nmDiscount);
            panel2.Controls.Add(btnCheckOut);
            panel2.Controls.Add(txbFinalPrice);
            panel2.Controls.Add(txbUsedPoint);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txbTotalPrice);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 344);
            panel2.TabIndex = 1;
            // 
            // nmDiscount
            // 
            nmDiscount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nmDiscount.Location = new Point(3, 111);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(279, 23);
            nmDiscount.TabIndex = 8;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            nmDiscount.ValueChanged += nmDiscount_ValueChanged;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(207, 309);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(75, 23);
            btnCheckOut.TabIndex = 8;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // txbFinalPrice
            // 
            txbFinalPrice.BackColor = SystemColors.Window;
            txbFinalPrice.Location = new Point(3, 270);
            txbFinalPrice.Name = "txbFinalPrice";
            txbFinalPrice.ReadOnly = true;
            txbFinalPrice.Size = new Size(279, 23);
            txbFinalPrice.TabIndex = 12;
            txbFinalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txbUsedPoint
            // 
            txbUsedPoint.BackColor = SystemColors.Window;
            txbUsedPoint.Location = new Point(3, 194);
            txbUsedPoint.Name = "txbUsedPoint";
            txbUsedPoint.ReadOnly = true;
            txbUsedPoint.Size = new Size(279, 23);
            txbUsedPoint.TabIndex = 11;
            txbUsedPoint.Text = "0";
            txbUsedPoint.TextAlign = HorizontalAlignment.Center;
            txbUsedPoint.TextChanged += txbUsedPoint_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 234);
            label7.Name = "label7";
            label7.Size = new Size(230, 22);
            label7.TabIndex = 10;
            label7.Text = "Số tiền phải thanh toán:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 155);
            label6.Name = "label6";
            label6.Size = new Size(64, 22);
            label6.TabIndex = 9;
            label6.Text = "Điểm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 72);
            label5.Name = "label5";
            label5.Size = new Size(132, 22);
            label5.TabIndex = 8;
            label5.Text = "Giảm giá (%):";
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.BackColor = SystemColors.Window;
            txbTotalPrice.Location = new Point(3, 35);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(279, 23);
            txbTotalPrice.TabIndex = 7;
            txbTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 3;
            label4.Text = "Tổng tiền:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUnusePoint);
            panel3.Controls.Add(btnUsePoint);
            panel3.Controls.Add(txbCustomerPoint);
            panel3.Controls.Add(txbSearchedCustomerUsername);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(303, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 233);
            panel3.TabIndex = 2;
            // 
            // btnUnusePoint
            // 
            btnUnusePoint.Location = new Point(81, 198);
            btnUnusePoint.Name = "btnUnusePoint";
            btnUnusePoint.Size = new Size(113, 23);
            btnUnusePoint.TabIndex = 7;
            btnUnusePoint.Text = "Không dùng điểm";
            btnUnusePoint.UseVisualStyleBackColor = true;
            btnUnusePoint.Click += btnUnusePoint_Click;
            // 
            // btnUsePoint
            // 
            btnUsePoint.Location = new Point(200, 198);
            btnUsePoint.Name = "btnUsePoint";
            btnUsePoint.Size = new Size(75, 23);
            btnUsePoint.TabIndex = 6;
            btnUsePoint.Text = "Dùng điểm";
            btnUsePoint.UseVisualStyleBackColor = true;
            btnUsePoint.Click += btnUsePoint_Click;
            // 
            // txbCustomerPoint
            // 
            txbCustomerPoint.BackColor = SystemColors.Window;
            txbCustomerPoint.Location = new Point(3, 159);
            txbCustomerPoint.Name = "txbCustomerPoint";
            txbCustomerPoint.ReadOnly = true;
            txbCustomerPoint.Size = new Size(272, 23);
            txbCustomerPoint.TabIndex = 5;
            txbCustomerPoint.Text = "0";
            txbCustomerPoint.TextAlign = HorizontalAlignment.Center;
            // 
            // txbSearchedCustomerUsername
            // 
            txbSearchedCustomerUsername.BackColor = SystemColors.Window;
            txbSearchedCustomerUsername.Location = new Point(3, 74);
            txbSearchedCustomerUsername.Name = "txbSearchedCustomerUsername";
            txbSearchedCustomerUsername.ReadOnly = true;
            txbSearchedCustomerUsername.Size = new Size(272, 23);
            txbSearchedCustomerUsername.TabIndex = 3;
            txbSearchedCustomerUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 123);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 4;
            label3.Text = "Điểm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(167, 22);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng:";
            // 
            // fCheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 368);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fCheckOut";
            Text = "Thanh toán";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearchCustomerUsername;
        private TextBox txbCustomerUsername;
        private Label label1;
        private Panel panel2;
        private Button btnCheckOut;
        private TextBox txbFinalPrice;
        private TextBox txbUsedPoint;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txbTotalPrice;
        private Label label4;
        private Panel panel3;
        private Button btnUnusePoint;
        private Button btnUsePoint;
        private TextBox txbCustomerPoint;
        private TextBox txbSearchedCustomerUsername;
        private Label label3;
        private Label label2;
        private NumericUpDown nmDiscount;
    }
}