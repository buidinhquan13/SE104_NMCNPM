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
    public partial class fCheckOut : Form
    {
        public fCheckOut(TextBox txb, int id)
        {
            InitializeComponent();

            IDBill = id;

            txbTotalPrice.Text = txb.Text;

            txbFinalPrice.Text = txb.Text;
        }

        private int IDBill = 0;

        private void btnSearchCustomerUsername_Click(object sender, EventArgs e)
        {
            string name = txbCustomerUsername.Text;

            Customer customer = CustomerDAO.Instance.SearchCustomerByUsername(name);

            if (customer != null)
            {
                txbSearchedCustomerUsername.Text = customer.Username;
                txbCustomerPoint.Text = (customer.Point).ToString();
            }
        }

        private void btnUsePoint_Click(object sender, EventArgs e)
        {
            txbUsedPoint.Text = txbCustomerPoint.Text;
            txbCustomerPoint.Text = ("0").ToString();
        }

        private void btnUnusePoint_Click(object sender, EventArgs e)
        {
            txbCustomerPoint.Text = txbUsedPoint.Text;
            txbUsedPoint.Text = ("0").ToString();
        }

        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            string[] str = (txbTotalPrice.Text.Split(',')[0]).Split('.');
            string price = "";
            foreach (string s in str)
            {
                price += s;
            }
            float TotalPrice = (float)Convert.ToDouble(price);

            float Discount = (float)nmDiscount.Value;
            float Point = (float)Convert.ToDouble(txbUsedPoint.Text);

            float FinalTotalPrice = TotalPrice - TotalPrice * Discount / 100 - Point;

            CultureInfo culture = new CultureInfo("vi-VN");
            string strFinalTotalPrice = FinalTotalPrice.ToString("c2", culture);
            txbFinalPrice.Text = strFinalTotalPrice;
        }

        private void txbUsedPoint_TextChanged(object sender, EventArgs e)
        {
            string[] str = (txbTotalPrice.Text.Split(',')[0]).Split('.');
            string price = "";
            foreach (string s in str)
            {
                price += s;
            }
            float TotalPrice = (float)Convert.ToDouble(price);

            float Discount = (float)nmDiscount.Value;
            float Point = (float)Convert.ToDouble(txbUsedPoint.Text);

            float FinalTotalPrice = TotalPrice - TotalPrice * Discount / 100 - Point;

            CultureInfo culture = new CultureInfo("vi-VN");
            string strFinalTotalPrice = FinalTotalPrice.ToString("c2", culture);
            txbFinalPrice.Text = strFinalTotalPrice;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            float discount = (float)nmDiscount.Value;

            string[] str = (txbFinalPrice.Text.Split(',')[0]).Split('.');
            string price = "";
            foreach (string s in str)
            {
                price += s;
            }
            float finalPrice = (float)Convert.ToDouble(price);

            if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn?\nTổng tiền: {0}", finalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.CheckOut(IDBill, discount, (float)finalPrice);

                float point = (float)Convert.ToDouble(txbCustomerPoint.Text) + finalPrice / 10;
                string name = txbCustomerUsername.Text;
                CustomerDAO.Instance.UpdatePoint(name, point);

                this.Close();
            }
        }
    }
}
