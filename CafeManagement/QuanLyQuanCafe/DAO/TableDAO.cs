using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO? instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; } 
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow row in data.Rows) 
            {
                Table table = new Table(row);
                tableList.Add(table);
            }

            return tableList;
        }

        public void SwitchTable(int id1, int id2) 
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idFirstTable , @idSecondTable", new object[] { id1, id2 });
        }

        public bool UpdateTable(int id, string name, int number)
        {
            string query = string.Format("UPDATE DrinkTable SET Name = N'{1}', Number = {2} WHERE ID = {0}", id, name, number);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool AddTable(string name, int number)
        {
            string query = string.Format("INSERT DrinkTable (Name, Number) VALUES (N'{0}', {1})", name, number);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int id) 
        {
            string query = string.Format("UPDATE DrinkTable SET isEnabled = 0 WHERE ID = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int GetNumberBillUncheckOutByTableID(int id)
        {
            string query = string.Format("SELECT * FROM Bill WHERE IDTable = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result;
        }
    }
}
