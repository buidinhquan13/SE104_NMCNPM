using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class fAddCustomer : Form
    {
        public fAddCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = "";
            try { name = txbCustomerUsername.Text; }
            catch { return; }
            if (name == "")
                return;

            if (CustomerDAO.Instance.AddCustomer(name))
                MessageBox.Show("Thêm khách hàng thành công!");
            else
                MessageBox.Show("Thêm khách hàng thất bại!");
        }
    }
}
