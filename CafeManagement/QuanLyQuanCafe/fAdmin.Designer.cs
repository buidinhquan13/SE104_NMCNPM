namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tpDrink = new TabPage();
            panel5 = new Panel();
            panel8 = new Panel();
            txbDrinkName = new TextBox();
            label2 = new Label();
            panel10 = new Panel();
            nmDrinkPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbDrinkCategory = new ComboBox();
            label3 = new Label();
            panel7 = new Panel();
            txbIDDrink = new TextBox();
            panel4 = new Panel();
            btnViewDrink = new Button();
            btnUpdateDrink = new Button();
            btnDeleteDrink = new Button();
            btnInsertDrink = new Button();
            panel3 = new Panel();
            dtgvDrink = new DataGridView();
            tpDrinkCategory = new TabPage();
            panel18 = new Panel();
            dtgvDrinkCategory = new DataGridView();
            panel12 = new Panel();
            panel15 = new Panel();
            txbDrinkCategoryName = new TextBox();
            label7 = new Label();
            panel16 = new Panel();
            txbDrinkCategoryID = new TextBox();
            panel17 = new Panel();
            btnShowDrinkCategory = new Button();
            btnUpdateDrinkCategory = new Button();
            btnDeleteDrinkCategory = new Button();
            btnAddDrinkCategory = new Button();
            tpTable = new TabPage();
            panel11 = new Panel();
            dtgvTable = new DataGridView();
            panel13 = new Panel();
            panel28 = new Panel();
            txbTableNumber = new TextBox();
            label13 = new Label();
            panel21 = new Panel();
            txbTableStatus = new TextBox();
            label9 = new Label();
            panel14 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel19 = new Panel();
            txbTableID = new TextBox();
            panel20 = new Panel();
            btnShowTable = new Button();
            btnUpdateTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpAccount = new TabPage();
            panel22 = new Panel();
            dtgvAccount = new DataGridView();
            panel23 = new Panel();
            btnResetPassword = new Button();
            panel24 = new Panel();
            nmAccountType = new NumericUpDown();
            label10 = new Label();
            panel25 = new Panel();
            txbAccountDisplayName = new TextBox();
            label11 = new Label();
            panel26 = new Panel();
            txbAccountUsername = new TextBox();
            label12 = new Label();
            panel27 = new Panel();
            btnShowAccount = new Button();
            btnUpdateAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            tpCustomer = new TabPage();
            panel31 = new Panel();
            panel32 = new Panel();
            txbCustomerPoint = new TextBox();
            label14 = new Label();
            panel33 = new Panel();
            txbCustomerRegisterDate = new TextBox();
            label15 = new Label();
            panel34 = new Panel();
            txbCustomerUsername = new TextBox();
            label16 = new Label();
            panel30 = new Panel();
            dtgvCustomer = new DataGridView();
            panel29 = new Panel();
            btnShowCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnAddCustomer = new Button();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tpDrink.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDrinkPrice).BeginInit();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDrink).BeginInit();
            tpDrinkCategory.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDrinkCategory).BeginInit();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            tpTable.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel13.SuspendLayout();
            panel28.SuspendLayout();
            panel21.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            tpAccount.SuspendLayout();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).BeginInit();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            tpCustomer.SuspendLayout();
            panel31.SuspendLayout();
            panel32.SuspendLayout();
            panel33.SuspendLayout();
            panel34.SuspendLayout();
            panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            panel29.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpDrink);
            tcAdmin.Controls.Add(tpDrinkCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Controls.Add(tpCustomer);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(776, 426);
            tcAdmin.TabIndex = 0;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(768, 398);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(6, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 348);
            panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowTemplate.Height = 25;
            dtgvBill.Size = new Size(750, 342);
            dtgvBill.TabIndex = 0;
            dtgvBill.CellContentClick += dtgvBill_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 32);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(459, 6);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 4;
            label6.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 3;
            label1.Text = "Từ ngày:";
            label1.Click += label1_Click;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(344, 3);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(75, 23);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(553, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(200, 23);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(88, 4);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // tpDrink
            // 
            tpDrink.Controls.Add(panel5);
            tpDrink.Controls.Add(panel4);
            tpDrink.Controls.Add(panel3);
            tpDrink.Location = new Point(4, 24);
            tpDrink.Name = "tpDrink";
            tpDrink.Padding = new Padding(3);
            tpDrink.Size = new Size(768, 398);
            tpDrink.TabIndex = 1;
            tpDrink.Text = "Đồ uống";
            tpDrink.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(441, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(321, 319);
            panel5.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(txbDrinkName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(315, 37);
            panel8.TabIndex = 2;
            // 
            // txbDrinkName
            // 
            txbDrinkName.Location = new Point(125, 6);
            txbDrinkName.MaxLength = 100;
            txbDrinkName.Name = "txbDrinkName";
            txbDrinkName.Size = new Size(187, 23);
            txbDrinkName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel10
            // 
            panel10.Controls.Add(nmDrinkPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 89);
            panel10.Name = "panel10";
            panel10.Size = new Size(315, 37);
            panel10.TabIndex = 3;
            // 
            // nmDrinkPrice
            // 
            nmDrinkPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nmDrinkPrice.Location = new Point(125, 10);
            nmDrinkPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nmDrinkPrice.Name = "nmDrinkPrice";
            nmDrinkPrice.Size = new Size(187, 23);
            nmDrinkPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbDrinkCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 46);
            panel9.Name = "panel9";
            panel9.Size = new Size(315, 37);
            panel9.TabIndex = 3;
            // 
            // cbDrinkCategory
            // 
            cbDrinkCategory.BackColor = SystemColors.Window;
            cbDrinkCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrinkCategory.ForeColor = SystemColors.WindowText;
            cbDrinkCategory.FormattingEnabled = true;
            cbDrinkCategory.Location = new Point(125, 6);
            cbDrinkCategory.MaxLength = 100;
            cbDrinkCategory.Name = "cbDrinkCategory";
            cbDrinkCategory.Size = new Size(187, 23);
            cbDrinkCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 0;
            label3.Text = "Danh mục:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbIDDrink);
            panel7.Location = new Point(3, 186);
            panel7.Name = "panel7";
            panel7.Size = new Size(315, 37);
            panel7.TabIndex = 1;
            // 
            // txbIDDrink
            // 
            txbIDDrink.BackColor = SystemColors.Window;
            txbIDDrink.BorderStyle = BorderStyle.None;
            txbIDDrink.ForeColor = SystemColors.Window;
            txbIDDrink.Location = new Point(34, 3);
            txbIDDrink.Name = "txbIDDrink";
            txbIDDrink.Size = new Size(187, 16);
            txbIDDrink.TabIndex = 1;
            txbIDDrink.TextChanged += txbIDDrink_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnViewDrink);
            panel4.Controls.Add(btnUpdateDrink);
            panel4.Controls.Add(btnDeleteDrink);
            panel4.Controls.Add(btnInsertDrink);
            panel4.Location = new Point(441, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 61);
            panel4.TabIndex = 1;
            // 
            // btnViewDrink
            // 
            btnViewDrink.Location = new Point(242, 3);
            btnViewDrink.Name = "btnViewDrink";
            btnViewDrink.Size = new Size(73, 55);
            btnViewDrink.TabIndex = 3;
            btnViewDrink.Text = "Xem tất cả";
            btnViewDrink.UseVisualStyleBackColor = true;
            btnViewDrink.Click += btnViewDrink_Click;
            // 
            // btnUpdateDrink
            // 
            btnUpdateDrink.Location = new Point(164, 3);
            btnUpdateDrink.Name = "btnUpdateDrink";
            btnUpdateDrink.Size = new Size(73, 55);
            btnUpdateDrink.TabIndex = 2;
            btnUpdateDrink.Text = "Sửa";
            btnUpdateDrink.UseVisualStyleBackColor = true;
            btnUpdateDrink.Click += btnUpdateDrink_Click;
            // 
            // btnDeleteDrink
            // 
            btnDeleteDrink.Location = new Point(85, 3);
            btnDeleteDrink.Name = "btnDeleteDrink";
            btnDeleteDrink.Size = new Size(73, 55);
            btnDeleteDrink.TabIndex = 1;
            btnDeleteDrink.Text = "Xóa";
            btnDeleteDrink.UseVisualStyleBackColor = true;
            btnDeleteDrink.Click += btnDeleteDrink_Click;
            // 
            // btnInsertDrink
            // 
            btnInsertDrink.Location = new Point(6, 3);
            btnInsertDrink.Name = "btnInsertDrink";
            btnInsertDrink.Size = new Size(73, 55);
            btnInsertDrink.TabIndex = 0;
            btnInsertDrink.Text = "Thêm";
            btnInsertDrink.UseVisualStyleBackColor = true;
            btnInsertDrink.Click += btnInsertDrink_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvDrink);
            panel3.Location = new Point(6, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 386);
            panel3.TabIndex = 0;
            // 
            // dtgvDrink
            // 
            dtgvDrink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDrink.Location = new Point(3, 3);
            dtgvDrink.Name = "dtgvDrink";
            dtgvDrink.RowTemplate.Height = 25;
            dtgvDrink.Size = new Size(423, 380);
            dtgvDrink.TabIndex = 0;
            dtgvDrink.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tpDrinkCategory
            // 
            tpDrinkCategory.Controls.Add(panel18);
            tpDrinkCategory.Controls.Add(panel12);
            tpDrinkCategory.Controls.Add(panel17);
            tpDrinkCategory.Location = new Point(4, 24);
            tpDrinkCategory.Name = "tpDrinkCategory";
            tpDrinkCategory.Padding = new Padding(3);
            tpDrinkCategory.Size = new Size(768, 398);
            tpDrinkCategory.TabIndex = 2;
            tpDrinkCategory.Text = "Danh mục";
            tpDrinkCategory.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Controls.Add(dtgvDrinkCategory);
            panel18.Location = new Point(8, 6);
            panel18.Name = "panel18";
            panel18.Size = new Size(429, 385);
            panel18.TabIndex = 8;
            // 
            // dtgvDrinkCategory
            // 
            dtgvDrinkCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDrinkCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDrinkCategory.Location = new Point(3, 3);
            dtgvDrinkCategory.Name = "dtgvDrinkCategory";
            dtgvDrinkCategory.RowTemplate.Height = 25;
            dtgvDrinkCategory.Size = new Size(423, 379);
            dtgvDrinkCategory.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(443, 73);
            panel12.Name = "panel12";
            panel12.Size = new Size(321, 319);
            panel12.TabIndex = 6;
            // 
            // panel15
            // 
            panel15.Controls.Add(txbDrinkCategoryName);
            panel15.Controls.Add(label7);
            panel15.Location = new Point(3, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(315, 37);
            panel15.TabIndex = 2;
            // 
            // txbDrinkCategoryName
            // 
            txbDrinkCategoryName.Location = new Point(125, 6);
            txbDrinkCategoryName.MaxLength = 50;
            txbDrinkCategoryName.Name = "txbDrinkCategoryName";
            txbDrinkCategoryName.Size = new Size(187, 23);
            txbDrinkCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(124, 19);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel16
            // 
            panel16.Controls.Add(txbDrinkCategoryID);
            panel16.Location = new Point(3, 131);
            panel16.Name = "panel16";
            panel16.Size = new Size(315, 37);
            panel16.TabIndex = 1;
            // 
            // txbDrinkCategoryID
            // 
            txbDrinkCategoryID.BackColor = SystemColors.Window;
            txbDrinkCategoryID.BorderStyle = BorderStyle.None;
            txbDrinkCategoryID.ForeColor = SystemColors.Window;
            txbDrinkCategoryID.Location = new Point(125, 6);
            txbDrinkCategoryID.Name = "txbDrinkCategoryID";
            txbDrinkCategoryID.ReadOnly = true;
            txbDrinkCategoryID.Size = new Size(187, 16);
            txbDrinkCategoryID.TabIndex = 1;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnShowDrinkCategory);
            panel17.Controls.Add(btnUpdateDrinkCategory);
            panel17.Controls.Add(btnDeleteDrinkCategory);
            panel17.Controls.Add(btnAddDrinkCategory);
            panel17.Location = new Point(443, 6);
            panel17.Name = "panel17";
            panel17.Size = new Size(321, 61);
            panel17.TabIndex = 5;
            // 
            // btnShowDrinkCategory
            // 
            btnShowDrinkCategory.Location = new Point(240, 3);
            btnShowDrinkCategory.Name = "btnShowDrinkCategory";
            btnShowDrinkCategory.Size = new Size(73, 55);
            btnShowDrinkCategory.TabIndex = 3;
            btnShowDrinkCategory.Text = "Xem tất cả";
            btnShowDrinkCategory.UseVisualStyleBackColor = true;
            btnShowDrinkCategory.Click += btnShowDrinkCategory_Click;
            // 
            // btnUpdateDrinkCategory
            // 
            btnUpdateDrinkCategory.Location = new Point(161, 3);
            btnUpdateDrinkCategory.Name = "btnUpdateDrinkCategory";
            btnUpdateDrinkCategory.Size = new Size(73, 55);
            btnUpdateDrinkCategory.TabIndex = 2;
            btnUpdateDrinkCategory.Text = "Sửa";
            btnUpdateDrinkCategory.UseVisualStyleBackColor = true;
            btnUpdateDrinkCategory.Click += btnUpdateDrinkCategory_Click;
            // 
            // btnDeleteDrinkCategory
            // 
            btnDeleteDrinkCategory.Location = new Point(82, 3);
            btnDeleteDrinkCategory.Name = "btnDeleteDrinkCategory";
            btnDeleteDrinkCategory.Size = new Size(73, 55);
            btnDeleteDrinkCategory.TabIndex = 1;
            btnDeleteDrinkCategory.Text = "Xóa";
            btnDeleteDrinkCategory.UseVisualStyleBackColor = true;
            btnDeleteDrinkCategory.Click += btnDeleteDrinkCategory_Click;
            // 
            // btnAddDrinkCategory
            // 
            btnAddDrinkCategory.Location = new Point(3, 3);
            btnAddDrinkCategory.Name = "btnAddDrinkCategory";
            btnAddDrinkCategory.Size = new Size(73, 55);
            btnAddDrinkCategory.TabIndex = 0;
            btnAddDrinkCategory.Text = "Thêm";
            btnAddDrinkCategory.UseVisualStyleBackColor = true;
            btnAddDrinkCategory.Click += btnAddDrinkCategory_Click;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel11);
            tpTable.Controls.Add(panel13);
            tpTable.Controls.Add(panel20);
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(768, 398);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(dtgvTable);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(429, 383);
            panel11.TabIndex = 11;
            // 
            // dtgvTable
            // 
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowTemplate.Height = 25;
            dtgvTable.Size = new Size(423, 377);
            dtgvTable.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel28);
            panel13.Controls.Add(panel21);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(panel19);
            panel13.Location = new Point(441, 70);
            panel13.Name = "panel13";
            panel13.Size = new Size(321, 319);
            panel13.TabIndex = 10;
            // 
            // panel28
            // 
            panel28.Controls.Add(txbTableNumber);
            panel28.Controls.Add(label13);
            panel28.Location = new Point(3, 89);
            panel28.Name = "panel28";
            panel28.Size = new Size(315, 37);
            panel28.TabIndex = 4;
            // 
            // txbTableNumber
            // 
            txbTableNumber.Location = new Point(125, 6);
            txbTableNumber.MaxLength = 20;
            txbTableNumber.Name = "txbTableNumber";
            txbTableNumber.Size = new Size(187, 23);
            txbTableNumber.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 10);
            label13.Name = "label13";
            label13.Size = new Size(87, 19);
            label13.TabIndex = 0;
            label13.Text = "Số lượng:";
            // 
            // panel21
            // 
            panel21.Controls.Add(txbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(3, 46);
            panel21.Name = "panel21";
            panel21.Size = new Size(315, 37);
            panel21.TabIndex = 3;
            // 
            // txbTableStatus
            // 
            txbTableStatus.BackColor = SystemColors.Window;
            txbTableStatus.Location = new Point(125, 6);
            txbTableStatus.MaxLength = 100;
            txbTableStatus.Name = "txbTableStatus";
            txbTableStatus.ReadOnly = true;
            txbTableStatus.Size = new Size(187, 23);
            txbTableStatus.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 10);
            label9.Name = "label9";
            label9.Size = new Size(91, 19);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbTableName);
            panel14.Controls.Add(label5);
            panel14.Location = new Point(3, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(315, 37);
            panel14.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(125, 6);
            txbTableName.MaxLength = 50;
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(187, 23);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            label5.Click += label5_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(txbTableID);
            panel19.Location = new Point(3, 204);
            panel19.Name = "panel19";
            panel19.Size = new Size(315, 37);
            panel19.TabIndex = 1;
            // 
            // txbTableID
            // 
            txbTableID.BackColor = SystemColors.Window;
            txbTableID.BorderStyle = BorderStyle.None;
            txbTableID.ForeColor = SystemColors.Window;
            txbTableID.Location = new Point(125, 6);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(187, 16);
            txbTableID.TabIndex = 1;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnShowTable);
            panel20.Controls.Add(btnUpdateTable);
            panel20.Controls.Add(btnDeleteTable);
            panel20.Controls.Add(btnAddTable);
            panel20.Location = new Point(441, 6);
            panel20.Name = "panel20";
            panel20.Size = new Size(321, 61);
            panel20.TabIndex = 9;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(245, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(73, 55);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem tất cả";
            btnShowTable.UseVisualStyleBackColor = true;
            btnShowTable.Click += btnShowTable_Click;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(166, 3);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(73, 55);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Sửa";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(87, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(73, 55);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(73, 55);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel22);
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel27);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(768, 398);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            panel22.Controls.Add(dtgvAccount);
            panel22.Location = new Point(6, 6);
            panel22.Name = "panel22";
            panel22.Size = new Size(429, 385);
            panel22.TabIndex = 14;
            panel22.Paint += panel22_Paint;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowTemplate.Height = 25;
            dtgvAccount.Size = new Size(423, 379);
            dtgvAccount.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel24);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Location = new Point(441, 72);
            panel23.Name = "panel23";
            panel23.Size = new Size(321, 319);
            panel23.TabIndex = 13;
            panel23.Paint += panel23_Paint;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(248, 132);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(67, 59);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel24
            // 
            panel24.Controls.Add(nmAccountType);
            panel24.Controls.Add(label10);
            panel24.Location = new Point(3, 89);
            panel24.Name = "panel24";
            panel24.Size = new Size(315, 37);
            panel24.TabIndex = 3;
            // 
            // nmAccountType
            // 
            nmAccountType.Location = new Point(125, 6);
            nmAccountType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmAccountType.Name = "nmAccountType";
            nmAccountType.Size = new Size(187, 23);
            nmAccountType.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(122, 19);
            label10.TabIndex = 0;
            label10.Text = "Loại tài khoản:";
            // 
            // panel25
            // 
            panel25.Controls.Add(txbAccountDisplayName);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(3, 46);
            panel25.Name = "panel25";
            panel25.Size = new Size(315, 37);
            panel25.TabIndex = 2;
            // 
            // txbAccountDisplayName
            // 
            txbAccountDisplayName.Location = new Point(125, 6);
            txbAccountDisplayName.MaxLength = 20;
            txbAccountDisplayName.Name = "txbAccountDisplayName";
            txbAccountDisplayName.Size = new Size(187, 23);
            txbAccountDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(104, 19);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbAccountUsername);
            panel26.Controls.Add(label12);
            panel26.Location = new Point(3, 3);
            panel26.Name = "panel26";
            panel26.Size = new Size(315, 37);
            panel26.TabIndex = 1;
            // 
            // txbAccountUsername
            // 
            txbAccountUsername.Location = new Point(125, 6);
            txbAccountUsername.MaxLength = 20;
            txbAccountUsername.Name = "txbAccountUsername";
            txbAccountUsername.Size = new Size(187, 23);
            txbAccountUsername.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 10);
            label12.Name = "label12";
            label12.Size = new Size(118, 19);
            label12.TabIndex = 0;
            label12.Text = "Tên tài khoản:";
            // 
            // panel27
            // 
            panel27.Controls.Add(btnShowAccount);
            panel27.Controls.Add(btnUpdateAccount);
            panel27.Controls.Add(btnDeleteAccount);
            panel27.Controls.Add(btnAddAccount);
            panel27.Location = new Point(441, 6);
            panel27.Name = "panel27";
            panel27.Size = new Size(321, 61);
            panel27.TabIndex = 12;
            panel27.Paint += panel27_Paint;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(245, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(73, 55);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem tất cả";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(166, 3);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(73, 55);
            btnUpdateAccount.TabIndex = 2;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(87, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(73, 55);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(73, 55);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // tpCustomer
            // 
            tpCustomer.Controls.Add(panel31);
            tpCustomer.Controls.Add(panel30);
            tpCustomer.Controls.Add(panel29);
            tpCustomer.Location = new Point(4, 24);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(3);
            tpCustomer.Size = new Size(768, 398);
            tpCustomer.TabIndex = 5;
            tpCustomer.Text = "Khách hàng";
            tpCustomer.UseVisualStyleBackColor = true;
            // 
            // panel31
            // 
            panel31.Controls.Add(panel32);
            panel31.Controls.Add(panel33);
            panel31.Controls.Add(panel34);
            panel31.Location = new Point(438, 73);
            panel31.Name = "panel31";
            panel31.Size = new Size(321, 319);
            panel31.TabIndex = 16;
            // 
            // panel32
            // 
            panel32.Controls.Add(txbCustomerPoint);
            panel32.Controls.Add(label14);
            panel32.Location = new Point(3, 89);
            panel32.Name = "panel32";
            panel32.Size = new Size(315, 37);
            panel32.TabIndex = 3;
            // 
            // txbCustomerPoint
            // 
            txbCustomerPoint.BackColor = SystemColors.Window;
            txbCustomerPoint.Location = new Point(147, 6);
            txbCustomerPoint.MaxLength = 20;
            txbCustomerPoint.Name = "txbCustomerPoint";
            txbCustomerPoint.ReadOnly = true;
            txbCustomerPoint.Size = new Size(165, 23);
            txbCustomerPoint.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(3, 10);
            label14.Name = "label14";
            label14.Size = new Size(54, 19);
            label14.TabIndex = 0;
            label14.Text = "Điểm:";
            // 
            // panel33
            // 
            panel33.Controls.Add(txbCustomerRegisterDate);
            panel33.Controls.Add(label15);
            panel33.Location = new Point(3, 46);
            panel33.Name = "panel33";
            panel33.Size = new Size(315, 37);
            panel33.TabIndex = 2;
            // 
            // txbCustomerRegisterDate
            // 
            txbCustomerRegisterDate.BackColor = SystemColors.Window;
            txbCustomerRegisterDate.Location = new Point(147, 6);
            txbCustomerRegisterDate.Name = "txbCustomerRegisterDate";
            txbCustomerRegisterDate.ReadOnly = true;
            txbCustomerRegisterDate.Size = new Size(165, 23);
            txbCustomerRegisterDate.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(3, 10);
            label15.Name = "label15";
            label15.Size = new Size(120, 19);
            label15.TabIndex = 0;
            label15.Text = "Ngày đăng ký:";
            // 
            // panel34
            // 
            panel34.Controls.Add(txbCustomerUsername);
            panel34.Controls.Add(label16);
            panel34.Location = new Point(3, 3);
            panel34.Name = "panel34";
            panel34.Size = new Size(315, 37);
            panel34.TabIndex = 1;
            // 
            // txbCustomerUsername
            // 
            txbCustomerUsername.Location = new Point(147, 6);
            txbCustomerUsername.MaxLength = 20;
            txbCustomerUsername.Name = "txbCustomerUsername";
            txbCustomerUsername.Size = new Size(165, 23);
            txbCustomerUsername.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(3, 10);
            label16.Name = "label16";
            label16.Size = new Size(138, 19);
            label16.TabIndex = 0;
            label16.Text = "Tên khách hàng:";
            label16.Click += label16_Click;
            // 
            // panel30
            // 
            panel30.Controls.Add(dtgvCustomer);
            panel30.Location = new Point(3, 6);
            panel30.Name = "panel30";
            panel30.Size = new Size(429, 386);
            panel30.TabIndex = 15;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new Point(3, 3);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.RowTemplate.Height = 25;
            dtgvCustomer.Size = new Size(423, 380);
            dtgvCustomer.TabIndex = 0;
            // 
            // panel29
            // 
            panel29.Controls.Add(btnShowCustomer);
            panel29.Controls.Add(btnDeleteCustomer);
            panel29.Controls.Add(btnAddCustomer);
            panel29.Location = new Point(438, 6);
            panel29.Name = "panel29";
            panel29.Size = new Size(321, 61);
            panel29.TabIndex = 13;
            // 
            // btnShowCustomer
            // 
            btnShowCustomer.Location = new Point(242, 3);
            btnShowCustomer.Name = "btnShowCustomer";
            btnShowCustomer.Size = new Size(73, 55);
            btnShowCustomer.TabIndex = 3;
            btnShowCustomer.Text = "Xem tất cả";
            btnShowCustomer.UseVisualStyleBackColor = true;
            btnShowCustomer.Click += btnShowCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(126, 3);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(73, 55);
            btnDeleteCustomer.TabIndex = 1;
            btnDeleteCustomer.Text = "Xóa";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(3, 3);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(73, 55);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Thêm";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            Text = "Admin";
            Load += fAdmin_Load;
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpDrink.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDrinkPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDrink).EndInit();
            tpDrinkCategory.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDrinkCategory).EndInit();
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel13.ResumeLayout(false);
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).EndInit();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            tpCustomer.ResumeLayout(false);
            panel31.ResumeLayout(false);
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            panel34.ResumeLayout(false);
            panel34.PerformLayout();
            panel30.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            panel29.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private Panel panel2;
        private DataGridView dtgvBill;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private TabPage tpDrink;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dtgvDrink;
        private TabPage tpDrinkCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Button btnViewDrink;
        private Button btnUpdateDrink;
        private Button btnDeleteDrink;
        private Button btnInsertDrink;
        private Panel panel10;
        private NumericUpDown nmDrinkPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbDrinkCategory;
        private Label label3;
        private Panel panel8;
        private TextBox txbDrinkName;
        private Label label2;
        private Panel panel7;
        private TextBox txbIDDrink;
        private Panel panel18;
        private DataGridView dtgvDrinkCategory;
        private Panel panel12;
        private Panel panel15;
        private TextBox txbDrinkCategoryName;
        private Label label7;
        private Panel panel16;
        private TextBox txbDrinkCategoryID;
        private Panel panel17;
        private Button btnShowDrinkCategory;
        private Button btnUpdateDrinkCategory;
        private Button btnDeleteDrinkCategory;
        private Button btnAddDrinkCategory;
        private Panel panel11;
        private DataGridView dtgvTable;
        private Panel panel13;
        private Panel panel14;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel19;
        private TextBox txbTableID;
        private Panel panel20;
        private Button btnShowTable;
        private Button btnUpdateTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel22;
        private DataGridView dtgvAccount;
        private Panel panel23;
        private Button btnResetPassword;
        private Panel panel24;
        private Label label10;
        private Panel panel25;
        private TextBox txbAccountDisplayName;
        private Label label11;
        private Panel panel26;
        private TextBox txbAccountUsername;
        private Label label12;
        private Panel panel27;
        private Button btnShowAccount;
        private Button btnUpdateAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private NumericUpDown nmAccountType;
        private Panel panel28;
        private TextBox txbTableNumber;
        private Label label13;
        private TabPage tpCustomer;
        private Panel panel31;
        private Panel panel32;
        private Label label14;
        private Panel panel33;
        private TextBox txbCustomerRegisterDate;
        private Label label15;
        private Panel panel34;
        private TextBox txbCustomerUsername;
        private Label label16;
        private Panel panel30;
        private DataGridView dtgvCustomer;
        private Panel panel29;
        private Button btnShowCustomer;
        private Button btnDeleteCustomer;
        private Button btnAddCustomer;
        private TextBox txbCustomerPoint;
        private Panel panel21;
        private Label label9;
        private TextBox txbTableStatus;
        private Label label1;
        private Label label6;
    }
}