using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using static System.Windows.Forms.ListViewItem;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set { loginAccount = value; AccessAdmin(loginAccount.Type); } }

        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadTable();
            LoadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }

        #region Method

        void AccessAdmin(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
        }

        void LoadCategory()
        {
            List<DrinkCategory> listCategory = DrinkCategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadListDrinkByCategoryID(int id)
        {
            List<Drink> listDrink = DrinkDAO.Instance.GetListDrinkByCategoryID(id);
            cbDrink.DataSource = listDrink;
            cbDrink.DisplayMember = "Name";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table table in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = table.Name + Environment.NewLine + table.Status + Environment.NewLine + "Số lượng: " + table.Number;

                btn.Click += btn_Click;
                btn.Tag = table;

                if (table.Status == "Trống")
                {
                    btn.BackColor = Color.LightGray;
                }
                else
                    btn.BackColor = Color.LightBlue;

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();

            List<Menu> listMenu = MenuDAO.Instance.GetListMenuByTable(id);

            float TotalPrice = 0;
            foreach (Menu item in listMenu)
            {
                ListViewItem lsvItem = new ListViewItem(item.DrinkName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());

                TotalPrice += item.Total;

                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txbTotalPrice.Text = TotalPrice.ToString("c2", culture);
        }

        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            Table? table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckOutBillIDByTableID(table.ID);
            int idDrink = (cbDrink.SelectedItem as Drink).ID;
            int count = (int)nmDrinkCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.AddBill(table.ID);
                BillInfoDAO.Instance.AddBillInfo(BillDAO.Instance.GetMaxID(), idDrink, count);
            }
            else
            {
                BillInfoDAO.Instance.AddBillInfo(idBill, idDrink, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.InsertDrink += f_InsertDrink;
            f.DeleteDrink += f_DeleteDrink;
            f.UpdateDrink += f_UpdateDrink;
            f.AddDrinkCategory += f_AddDrinkCategory;
            f.UpdateDrinkCategory += f_UpdateDrinkCategory;
            f.DeleteDrinkCategory += f_DeleteDrinkCategory;
            f.AddTable += f_AddTable;
            f.UpdateTable += f_UpdateTable;
            f.DeleteTable += f_DeleteTable;
            f.ShowDialog();
        }

        private void f_AddTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxTable(cbSwitchTable);
        }

        private void f_UpdateTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxTable(cbSwitchTable);
        }

        private void f_DeleteTable(object? sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxTable(cbSwitchTable);
        }

        private void f_DeleteDrinkCategory(object? sender, EventArgs e)
        {
            LoadCategory();

        }

        private void f_UpdateDrinkCategory(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        private void f_AddDrinkCategory(object? sender, EventArgs e)
        {
            LoadCategory();
        }

        private void f_UpdateDrink(object? sender, EventArgs e)
        {
            LoadListDrinkByCategoryID((cbCategory.SelectedItem as DrinkCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_DeleteDrink(object? sender, EventArgs e)
        {
            LoadListDrinkByCategoryID((cbCategory.SelectedItem as DrinkCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void f_InsertDrink(object? sender, EventArgs e)
        {
            LoadListDrinkByCategoryID((cbCategory.SelectedItem as DrinkCategory).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox? cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            DrinkCategory? selected = cb.SelectedItem as DrinkCategory;
            id = selected.ID;

            LoadListDrinkByCategoryID(id);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn!");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckOutBillIDByTableID(table.ID);
            if (idBill != -1)
            {
                fCheckOut f = new fCheckOut(txbTotalPrice, idBill);
                f.ShowDialog();
                LoadTable();
                ShowBill(table.ID);
            }

        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if ((lsvBill.Tag as Table).Status != "Trống")
            {
                int id1 = (lsvBill.Tag as Table).ID;
                int id2 = (cbSwitchTable.SelectedItem as Table).ID;

                if (MessageBox.Show(string.Format("Bạn có muốn chuyển {0} với {1}?", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.SwitchTable(id1, id2);

                    LoadTable();
                }
            }
        }

        private void btnSubtractDrink_Click(object sender, EventArgs e)
        {
            Table? table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckOutBillIDByTableID(table.ID);
            int idDrink = (cbDrink.SelectedItem as Drink).ID;
            int count = 0 - (int)nmDrinkCount.Value;

            if (idBill == -1 || !(BillInfoDAO.Instance.HaveDrinkByDrinkIDAndBillID(idBill, idDrink)))
            {
                MessageBox.Show("Vui lòng thêm món!");
            }
            else
            {
                BillInfoDAO.Instance.AddBillInfo(idBill, idDrink, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }


        #endregion

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void txbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddCustomer f = new fAddCustomer();
            f.ShowDialog();
        }

        private void muaMangVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTakeAway f = new fTakeAway();
            f.ShowDialog();

            int idBill = BillDAO.Instance.GetUncheckOutBillIDForTakeAway();

            if (BillDAO.Instance.GetUncheckOutBillByID(idBill) > 0)
            {
                BillDAO.Instance.DeleteBillByBillID(idBill);
            }


        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
