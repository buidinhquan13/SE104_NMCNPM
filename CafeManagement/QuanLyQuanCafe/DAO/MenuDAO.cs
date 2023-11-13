using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO? instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; } 
            private set => instance = value; 
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT d.Name, bi.Count, d.Price, d.Price*bi.Count AS Total FROM BillInfo AS bi, Bill AS b, Drink AS d WHERE bi.IDBill = b.ID AND bi.IDDrink = d.ID AND d.isEnabled = 1 AND b.Status = 0 AND b.IDTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows) 
            {
                Menu menu = new Menu(row);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<Menu> GetListMenuForTakeAway()
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT d.Name, bi.Count, d.Price, d.Price*bi.Count AS Total FROM BillInfo AS bi, Bill AS b, Drink AS d WHERE bi.IDBill = b.ID AND bi.IDDrink = d.ID AND d.isEnabled = 1 AND b.Status = 0 AND b.IDTable IS NULL ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Menu menu = new Menu(row);
                listMenu.Add(menu);
            }

            return listMenu;
        }

    }
}
