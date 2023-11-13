using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO? instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set => instance = value; 
        }

        private BillDAO() { }

        public int GetUncheckOutBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE IDTable = " + id + " AND Status = 0");

            if (data.Rows.Count > 0) 
            {
                Bill bill = new Bill(data.Rows[0]);

                return bill.ID; 
            }

            return -1;
        }

        public void AddBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }

        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public void CheckOut(int id, float discount, float totalPrice)
        {
            string query = "UPDATE Bill SET DateCheckOut = GetDate(), Status = 1, " + "Discount = " + discount + ", totalPrice = " + totalPrice + " WHERE ID = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetUncheckOutBillIDForTakeAway()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE IDTable IS NULL AND Status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);

                return bill.ID;
            }

            return -1;
        }

        public void AddBillForTakeAway()
        {
            string query = "INSERT Bill (IDTable) VALUES (NULL)";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetUncheckOutBillByID(int id)
        {
            string query = string.Format("SELECT * FROM Bill WHERE ID = {0} AND Status = 0", id);

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows) 
            {
                Bill bill = new Bill(row);

                return bill.ID;
            }

            return -1;
        }

        public void DeleteBillByBillID(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByIDBIll(id);

            string query = string.Format("DELETE Bill WHERE ID = {0}", id);

            DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetUncheckOutBillByIDDrink(int id)
        {
            string query = "SELECT * FROM Bill AS b, BillInfo AS bi, Drink AS d WHERE b.ID = bi.IDBill AND bi.IDDrink = d.ID AND b.Status = 0";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result;
        }
    }
}
