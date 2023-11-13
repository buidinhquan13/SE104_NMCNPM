using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO? instance;

        public static BillInfoDAO Instance 
        { 
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set => instance = value; 
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE IDBill = " + id);

            foreach (DataRow row in data.Rows)        
            {
                BillInfo info = new BillInfo(row);
                list.Add(info); 
            }

            return list;
        }

        public void AddBillInfo(int idBill, int idDrink, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBillInfo @idBill , @idDrink , @count", new object[] { idBill, idDrink, count });
        }

        public void DeleteBillInfoByIDDrink(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE BillInfo WHERE IDDrink = " + id);
        }

        public bool HaveDrinkByDrinkIDAndBillID(int idBill, int idDrink)
        {
            string query = string.Format("SELECT * FROM BillInfo WHERE IDBill = {0} AND IDDrink = {1}", idBill, idDrink);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public void DeleteBillInfoByIDBIll(int id)
        {
            string query = string.Format("DELETE FROM BillInfo WHERE IDBill = {0}", id);

            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
