namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thêmKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            muaTrựcTiếpToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            btnSubtractDrink = new Button();
            nmDrinkCount = new NumericUpDown();
            btnAddDrink = new Button();
            cbDrink = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            fileSystemWatcher1 = new FileSystemWatcher();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDrinkCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinToolStripMenuItem, thêmKháchHàngToolStripMenuItem, muaTrựcTiếpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(771, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(122, 20);
            thôngTinToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            thêmKháchHàngToolStripMenuItem.Size = new Size(114, 20);
            thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            thêmKháchHàngToolStripMenuItem.Click += thêmKháchHàngToolStripMenuItem_Click;
            // 
            // muaTrựcTiếpToolStripMenuItem
            // 
            muaTrựcTiếpToolStripMenuItem.Name = "muaTrựcTiếpToolStripMenuItem";
            muaTrựcTiếpToolStripMenuItem.Size = new Size(92, 20);
            muaTrựcTiếpToolStripMenuItem.Text = "Mua mang về";
            muaTrựcTiếpToolStripMenuItem.Click += muaMangVềToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(413, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 280);
            panel2.TabIndex = 2;
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
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
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
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(413, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 63);
            panel3.TabIndex = 3;
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
            txbTotalPrice.TextChanged += txbTotalPrice_TextChanged;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 31);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(104, 23);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(104, 23);
            btnSwitchTable.TabIndex = 3;
            btnSwitchTable.Text = "Chuyển đến bàn";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
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
            // panel4
            // 
            panel4.Controls.Add(btnSubtractDrink);
            panel4.Controls.Add(nmDrinkCount);
            panel4.Controls.Add(btnAddDrink);
            panel4.Controls.Add(cbDrink);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(413, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 58);
            panel4.TabIndex = 4;
            // 
            // btnSubtractDrink
            // 
            btnSubtractDrink.Location = new Point(227, 32);
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
            cbDrink.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrink.FormattingEnabled = true;
            cbDrink.Location = new Point(3, 32);
            cbDrink.MaxLength = 100;
            cbDrink.Name = "cbDrink";
            cbDrink.Size = new Size(218, 23);
            cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.MaxLength = 100;
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(218, 23);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 27);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(395, 413);
            flpTable.TabIndex = 5;
            flpTable.Paint += flpTable_Paint;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 452);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            Text = "Phần mềm quản lý quán Cafe";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmDrinkCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private Button btnAddDrink;
        private ComboBox cbDrink;
        private ComboBox cbCategory;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private Button btnCheckOut;
        private NumericUpDown nmDrinkCount;
        private FlowLayoutPanel flpTable;
        private FileSystemWatcher fileSystemWatcher1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private ToolStripMenuItem muaTrựcTiếpToolStripMenuItem;
        private Button btnSubtractDrink;
    }
}