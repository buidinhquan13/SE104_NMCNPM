namespace QuanLyQuanCafe
{
    partial class fTakeAway
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
            panel4 = new Panel();
            btnSubtractDrink = new Button();
            nmDrinkCount = new NumericUpDown();
            btnAddDrink = new Button();
            cbDrink = new ComboBox();
            cbCategory = new ComboBox();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            btnCheckOut = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDrinkCount).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSubtractDrink);
            panel4.Controls.Add(nmDrinkCount);
            panel4.Controls.Add(btnAddDrink);
            panel4.Controls.Add(cbDrink);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 58);
            panel4.TabIndex = 5;
            // 
            // btnSubtractDrink
            // 
            btnSubtractDrink.Location = new Point(227, 31);
            btnSubtractDrink.Name = "btnSubtractDrink";
            btnSubtractDrink.Size = new Size(61, 23);
            btnSubtractDrink.TabIndex = 3;
            btnSubtractDrink.Text = "Bớt";
            btnSubtractDrink.UseVisualStyleBackColor = true;
            btnSubtractDrink.Click += btnSubtractDrink_Click;
            // 
            // nmDrinkCount
            // 
            nmDrinkCount.Location = new Point(294, 21);
            nmDrinkCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmDrinkCount.Name = "nmDrinkCount";
            nmDrinkCount.Size = new Size(49, 23);
            nmDrinkCount.TabIndex = 1;
            nmDrinkCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddDrink
            // 
            btnAddDrink.Location = new Point(227, 3);
            btnAddDrink.Name = "btnAddDrink";
            btnAddDrink.Size = new Size(61, 23);
            btnAddDrink.TabIndex = 2;
            btnAddDrink.Text = "Thêm";
            btnAddDrink.UseVisualStyleBackColor = true;
            btnAddDrink.Click += btnAddDrink_Click;
            // 
            // cbDrink
            // 
            cbDrink.FormattingEnabled = true;
            cbDrink.Location = new Point(3, 32);
            cbDrink.MaxLength = 100;
            cbDrink.Name = "cbDrink";
            cbDrink.Size = new Size(218, 23);
            cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.MaxLength = 100;
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(218, 23);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(12, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 280);
            panel2.TabIndex = 6;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(340, 274);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(12, 367);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 63);
            panel3.TabIndex = 7;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalPrice.ForeColor = Color.Tomato;
            txbTotalPrice.Location = new Point(151, 18);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(111, 26);
            txbTotalPrice.TabIndex = 5;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(268, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(75, 57);
            btnCheckOut.TabIndex = 0;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // fTakeAway
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 440);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "fTakeAway";
            Text = "Mua mang về";
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDrinkCount).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private NumericUpDown nmDrinkCount;
        private Button btnAddDrink;
        private ComboBox cbDrink;
        private ComboBox cbCategory;
        private Panel panel2;
        private ListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel3;
        private TextBox txbTotalPrice;
        private Button btnCheckOut;
        private Button btnSubtractDrink;
    }
}