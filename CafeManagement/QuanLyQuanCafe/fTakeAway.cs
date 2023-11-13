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

namespace QuanLyQuanCafe
{
    public partial class fTakeAway : Form
    {
        public fTakeAway()
        {
            InitializeComponent();

            LoadCategory();
        }

        void LoadCategory()
        {
            List<DrinkCategory> listCategory = DrinkCategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
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

        void LoadListDrinkByCategoryID(int id)
        {
            List<Drink> listDrink = DrinkDAO.Instance.GetListDrinkByCategoryID(id);
            cbDrink.DataSource = listDrink;
            cbDrink.DisplayMember = "Name";
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckOutBillIDForTakeAway();
            int idDrink = (cbDrink.SelectedItem as Drink).ID;
            int count = (int)nmDrinkCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.AddBillForTakeAway();
                BillInfoDAO.Instance.AddBillInfo(BillDAO.Instance.GetMaxID(), idDrink, count);

                ShowBill(idBill);
            }
            else
            {
                BillInfoDAO.Instance.AddBillInfo(idBill, idDrink, count);

                ShowBill(idBill);
            }
        }

        private void btnSubtractDrink_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckOutBillIDForTakeAway();
            int idDrink = (cbDrink.SelectedItem as Drink).ID;
            int count = 0 - (int)nmDrinkCount.Value;

            if (idBill == -1 || !(BillInfoDAO.Instance.HaveDrinkByDrinkIDAndBillID(idBill, idDrink)))
            {
                MessageBox.Show("Vui lòng thêm món!");
            }
            else
            {
                BillInfoDAO.Instance.AddBillInfo(idBill, idDrink, count);

                ShowBill(idBill);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();

            List<Menu> listMenu = MenuDAO.Instance.GetListMenuForTakeAway();

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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetUncheckOutBillIDForTakeAway();
            if (idBill != -1)
            {
                fCheckOut f = new fCheckOut(txbTotalPrice, idBill);
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
