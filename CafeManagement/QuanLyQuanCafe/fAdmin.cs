using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource ListDrink = new BindingSource();
        BindingSource ListAccount = new BindingSource();
        BindingSource ListDrinkCategory = new BindingSource();
        BindingSource ListTable = new BindingSource();
        BindingSource ListCustomer = new BindingSource();

        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();

            dtgvDrink.DataSource = ListDrink;
            dtgvAccount.DataSource = ListAccount;
            dtgvDrinkCategory.DataSource = ListDrinkCategory;
            dtgvTable.DataSource = ListTable;
            dtgvCustomer.DataSource = ListCustomer;

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListDrink();
            LoadAccount();
            LoadCategoryIntoComboBox(cbDrinkCategory);
            LoadListDrinkCategory();
            LoadListTable();
            LoadListCustomer();

            AddDrinkBinding();
            AddAccountBinding();
            AddDrinkCategoryBinding();
            AddTableBinding();
            AddCustomerBinding();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        #region Methods
        void AddCustomerBinding()
        {
            txbCustomerUsername.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txbCustomerRegisterDate.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "RegisterDate", true, DataSourceUpdateMode.Never));
            txbCustomerPoint.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Point", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cb.DataSource = DrinkCategoryDAO.Instance.GetListCategory();

            cb.DisplayMember = "Name";
        }

        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
            txbTableNumber.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Number", true, DataSourceUpdateMode.Never));
        }

        void AddDrinkBinding()
        {
            txbDrinkName.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbIDDrink.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmDrinkPrice.DataBindings.Add(new Binding("Value", dtgvDrink.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void AddDrinkCategoryBinding()
        {
            txbDrinkCategoryID.DataBindings.Add(new Binding("Text", dtgvDrinkCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbDrinkCategoryName.DataBindings.Add(new Binding("Text", dtgvDrinkCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void LoadListDrinkCategory()
        {
            ListDrinkCategory.DataSource = DrinkCategoryDAO.Instance.GetListCategory();
        }

        void LoadListTable()
        {
            ListTable.DataSource = TableDAO.Instance.LoadTableList();
        }

        void LoadListCustomer()
        {
            ListCustomer.DataSource = CustomerDAO.Instance.LoadListCustomer();
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }

        void LoadListDrink()
        {
            ListDrink.DataSource = DrinkDAO.Instance.GetListDrink();
        }

        List<Drink> SearchDrinkByName(string name)
        {
            List<Drink> list = DrinkDAO.Instance.SearchDrinkByName(name);

            return list;
        }

        void AddAccountBinding()
        {
            txbAccountUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            txbAccountDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            ListAccount.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccount(string name, string displayName, int type)
        {
            if (AccountDAO.Instance.AddAccount(name, displayName, type))
                MessageBox.Show("Thêm tài khoản thành công!\nMật khẩu mặc định: 0");
            else
                MessageBox.Show("Thêm tài khoản thất bại!");

            LoadAccount();
        }

        void UpdateAccount(string name, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(name, displayName, type))
                MessageBox.Show("Cập nhật tài khoản thành công!");
            else
                MessageBox.Show("Cập nhật tài khoản thất bại!");

            LoadAccount();
        }

        void DeleteAccount(string name)
        {
            if (loginAccount.Username.Equals(name))
            {
                MessageBox.Show("Không thể xóa tài khoản của chính bạn!");
                return;
            }

            if (AccountDAO.Instance.DeleteAccount(name))
                MessageBox.Show("Xóa tài khoản thành công!");
            else
                MessageBox.Show("Xóa tài khoản thất bại!");

            LoadAccount();
        }

        void ResetPassword(string name)
        {
            if (AccountDAO.Instance.ResetPassword(name))
                MessageBox.Show("Đặt lại mật khẩu thành công!");
            else
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
        }

        void LoadDrinkCategory()
        {
            ListDrinkCategory.DataSource = DrinkCategoryDAO.Instance.GetListCategory();
        }

        void LoadListDrinkCategoryInDrinkTab()
        {
            List<DrinkCategory> list = DrinkCategoryDAO.Instance.GetListCategory();
            cbDrinkCategory.DataSource = list;
            cbDrinkCategory.DisplayMember = "Name";
        }

        #endregion

        #region Events
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                name = txbTableName.Text;
            }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên bàn!");
                return;
            }

            int number = 0;
            try
            {
                number = Convert.ToInt32(txbTableNumber.Text);
            }
            catch { return; }
            if (number == 0)
            {
                MessageBox.Show("Nhập số lượng người của bàn!");
                return;
            }

            if (TableDAO.Instance.AddTable(name, number))
            {
                MessageBox.Show("Thêm bàn thành công!");
                LoadListTable();

                if (addTable != null)
                    addTable(this, new EventArgs());
            }
            else
                MessageBox.Show("Thêm món thất bại!");
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = 0;
            try { id = Convert.ToInt32(txbTableID.Text); }
            catch { return; }
            if (id == 0)
            {
                MessageBox.Show("Đã hết bàn!");
                return;
            }

            if (TableDAO.Instance.GetNumberBillUncheckOutByTableID(id) > 0)
            {
                MessageBox.Show("Bàn đang có hóa đơn chưa thanh toán!");
                return;
            }

            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công!");
                LoadListTable();

                if (deleteTable != null)
                    deleteTable(this, new EventArgs());
            }
            else
                MessageBox.Show("Xóa món thất bại!");
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            int id = 0;
            try { id = Convert.ToInt32(txbTableID.Text); }
            catch { return; }
            if (id == 0)
            {
                MessageBox.Show("Đã hết bàn!");
                return;
            }

            string name = "";
            try { name = txbTableName.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên bàn!");
                return;
            }

            int number = 0;
            try { Convert.ToInt32(txbTableNumber.Text); }
            catch { return; }
            if (number == 0)
            {
                MessageBox.Show("Nhập số lượng người của bàn!");
                return;
            }

            if (TableDAO.Instance.UpdateTable(id, name, number))
            {
                MessageBox.Show("Sửa bàn thành công!");
                LoadListTable();

                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
                MessageBox.Show("Sửa bàn thất bại!");
        }

        private event EventHandler addTable;
        public event EventHandler AddTable
        {
            add { addTable += value; }
            remove { addTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnViewDrink_Click(object sender, EventArgs e)
        {
            LoadListDrink();
        }


        private void txbIDDrink_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDrink.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvDrink.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;

                    DrinkCategory category = DrinkCategoryDAO.Instance.GetCategoryByID(id);

                    cbDrinkCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;

                    foreach (DrinkCategory item in cbDrinkCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        ++i;
                    }

                    cbDrinkCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnInsertDrink_Click(object sender, EventArgs e)
        {
            string name = "";
            try { name = txbDrinkName.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên thức uống!");
                return;
            }

            int idCategory = 0;
            try { idCategory = (cbDrinkCategory.SelectedItem as DrinkCategory).ID; }
            catch { return; }
            if (idCategory == 0)
            {
                MessageBox.Show("Chọn mục thức uống!");
                return;
            }

            float price = 0;
            try { price = (float)nmDrinkPrice.Value; }
            catch { return; }
            if (price == 0)
            {
                MessageBox.Show("Nhập giá của thức uống!");
                return;
            }

            if (DrinkDAO.Instance.AddDrink(name, idCategory, price))
            {
                MessageBox.Show("Thêm món thành công!");
                LoadListDrink();

                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm món thất bại!");
            }
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            int id = 0;
            try { id = Convert.ToInt32(txbIDDrink.Text); }
            catch { return; }
            if (id == 0)
            {
                MessageBox.Show("Đã hết thức uống!");
                return;
            }

            string name = "";
            try { name = txbDrinkName.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên thức uống!");
                return;
            }

            int idCategory = 0;
            try { idCategory = (cbDrinkCategory.SelectedItem as DrinkCategory).ID; }
            catch { return; }
            if (idCategory == 0)
            {
                MessageBox.Show("Chọn mục thức uống!");
                return;
            }

            float price = 0;
            try { price = (float)nmDrinkPrice.Value; }
            catch { return; }
            if (price == 0)
            {
                MessageBox.Show("Nhập giá của thức uống!");
                return;
            }

            if (DrinkDAO.Instance.UpdateDrink(id, name, idCategory, price))
            {
                MessageBox.Show("Sửa món thành công!");
                LoadListDrink();

                if (updateDrink != null)
                    updateDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa món thất bại!");
            }
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            int id = 0;
            try { id = Convert.ToInt32(txbIDDrink.Text); }
            catch { return; };
            if (id == 0)
            {
                MessageBox.Show("Đã hết thức uống!");
                return;
            }

            if (BillDAO.Instance.GetUncheckOutBillByIDDrink(id) > 0)
            {
                MessageBox.Show("Còn hóa đơn chứa thức uống chưa thanh toán!");
                return;
            }

            if (DrinkDAO.Instance.DeleteDrink(id))
            {
                MessageBox.Show("Xóa món thành công!");
                LoadListDrink();

                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xóa món thất bại!");
            }
        }

        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = "";
            try { username = txbAccountUsername.Text; }
            catch { return; }
            if (username == "")
            {
                MessageBox.Show("Nhập tên đăng nhập!");
                return;
            }

            string displayName = "";
            try { displayName = txbAccountDisplayName.Text; }
            catch { return; }
            if (displayName == "")
            {
                MessageBox.Show("Nhập tên hiển thị!");
                return;
            }

            int type = 0;
            try { type = (int)nmAccountType.Value; }
            catch { return; }
            if (type == null)
            {
                MessageBox.Show("Chọn loại tài khoản!");
                return;
            }

            AddAccount(username, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = "";
            try { username = txbAccountUsername.Text; }
            catch { return; }
            if (username == "")
            {
                MessageBox.Show("Chọn tài khoản!");
                return;
            }

            DeleteAccount(username);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string username = "";
            try { username = txbAccountUsername.Text; }
            catch { return; }
            if (username == "")
            {
                MessageBox.Show("Chọn tài khoản!");
                return;
            }

            string displayName = "";
            try { displayName = txbAccountDisplayName.Text; }
            catch { return; }
            if (displayName == "")
            {
                MessageBox.Show("Nhập tên hiển thị!");
                return;
            }

            int type = 0;
            try { type = (int)nmAccountType.Value; }
            catch { return; }
            if (type == 0)
            {
                MessageBox.Show("Chọn loại tài khoản!");
                return;
            }

            UpdateAccount(username, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string name = "";
            try { name = txbAccountUsername.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Chọn tài khoản!");
                return;
            }

            ResetPassword(name);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDrinkCategory_Click(object sender, EventArgs e)
        {
            string name = "";
            try { name = txbDrinkCategoryName.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên mục thức uống!");
                return;
            }

            if (DrinkCategoryDAO.Instance.AddDrinkCategory(name))
            {
                MessageBox.Show("Thêm mục thức uống thành công!");

                if (addDrinkCategory != null)
                    addDrinkCategory(this, new EventArgs());

                LoadDrinkCategory();
                LoadListDrinkCategoryInDrinkTab();
            }
            else
                MessageBox.Show("Thêm mục thức uống thất bại!");
        }

        private void btnDeleteDrinkCategory_Click(object sender, EventArgs e)
        {
            int id = 0;
            try { id = Convert.ToInt32(txbDrinkCategoryID.Text); }
            catch { return; }
            if (id == 0)
            {
                MessageBox.Show("Đã hết mục thức uống!");
                return;
            }

            if (DrinkDAO.Instance.GetListDrinkByCategoryID(id).Count > 0)
            {
                MessageBox.Show("Còn thức uống thuộc mục này!");
                return;
            }

            if (DrinkCategoryDAO.Instance.DeleteDrinkCategory(id))
            {
                MessageBox.Show("Xóa mục thức uống thành công!");

                if (deleteDrinkCategory != null)
                    deleteDrinkCategory(this, new EventArgs());

                LoadDrinkCategory();
                LoadListDrinkCategoryInDrinkTab();
            }
            else
                MessageBox.Show("Xóa mục thức uống thất bại!");
        }

        private void btnUpdateDrinkCategory_Click(object sender, EventArgs e)
        {
            int id = 0;
            try { id = Convert.ToInt32(txbDrinkCategoryID.Text); }
            catch { return; }
            if (id == 0)
            {
                MessageBox.Show("Đã hết mục thức uống!");
                return;
            }

            string name = "";
            try { name = txbDrinkCategoryName.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên mục thức uống!");
                return;
            }

            if (DrinkCategoryDAO.Instance.UpdateDrinkCategory(id, name))
            {
                MessageBox.Show("Cập nhật mục thức uống thành công!");

                if (updateDrinkCategory != null)
                    updateDrinkCategory(this, new EventArgs());

                LoadDrinkCategory();
                LoadListDrinkCategoryInDrinkTab();
            }
            else
                MessageBox.Show("Cập nhật mục thức uống thất bại!");
        }

        private event EventHandler addDrinkCategory;
        public event EventHandler AddDrinkCategory
        {
            add { addDrinkCategory += value; }
            remove { addDrinkCategory -= value; }
        }

        private event EventHandler updateDrinkCategory;
        public event EventHandler UpdateDrinkCategory
        {
            add { updateDrinkCategory += value; }
            remove { updateDrinkCategory -= value; }
        }

        private event EventHandler deleteDrinkCategory;
        public event EventHandler DeleteDrinkCategory
        {
            add { deleteDrinkCategory += value; }
            remove { deleteDrinkCategory -= value; }
        }

        private void btnShowDrinkCategory_Click(object sender, EventArgs e)
        {
            LoadDrinkCategory();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = "";
            try { name = txbCustomerUsername.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Nhập tên khách hàng!");
                return;
            }

            if (CustomerDAO.Instance.AddCustomer(name))
            {
                MessageBox.Show("Thêm khách hàng thành công!");

                if (addCustomer != null)
                    addCustomer(this, new EventArgs());

                LoadListCustomer();
            }
            else
                MessageBox.Show("Thêm khách hàng thất bại!");
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string name = "";
            try { name = txbCustomerUsername.Text; }
            catch { return; }
            if (name == "")
            {
                MessageBox.Show("Đã hết khách hàng!");
                return;
            }

            if (CustomerDAO.Instance.DeleteCustomer(name))
            {
                MessageBox.Show("Xóa khách hàng thành công!");

                if (deleteCustomer != null)
                    deleteCustomer(this, new EventArgs());

                LoadListCustomer();
            }
            else
                MessageBox.Show("Xóa khách hàng thất bại!");
        }

        private event EventHandler addCustomer;
        public event EventHandler AddCustomer
        {
            add { addCustomer += value; }
            remove { addCustomer -= value; }
        }

        private event EventHandler deleteCustomer;
        public event EventHandler DeleteCustomer
        {
            add { deleteCustomer += value; }
            remove { deleteCustomer -= value; }
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        #endregion

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
