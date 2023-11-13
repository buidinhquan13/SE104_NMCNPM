using System.Data;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO? instance;

        public static DrinkDAO Instance 
        {
            get { if (instance == null) instance = new DrinkDAO(); return instance; }
            private set => instance = value; 
        }

        private DrinkDAO() { }

        public List<Drink> GetListDrinkByCategoryID(int id)
        {
            List<Drink> list = new List<Drink>();

            string query = "SELECT * FROM Drink WHERE IDCategory = " + id + "AND isEnabled = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows) 
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }

            return list;
        }

        public List<Drink> GetListDrink()
        {
            List<Drink> list = new List<Drink>();

            string query = "SELECT * FROM Drink WHERE isEnabled = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }

            return list;
        }

        public bool AddDrink(string name, int id, float price)
        {
            string query = string.Format("INSERT Drink (Name, IDCategory, Price) VALUES (N'{0}', {1}, {2})", name, id, price);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDrink(int idDrink, string name, int idCategory, float price)
        {
            string query = string.Format("Update Drink SET Name = N'{1}', IDCategory = {2}, Price = {3} WHERE ID = {0}", idDrink, name, idCategory, price);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDrink(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByIDDrink(id);

            string query = string.Format("UPDATE Drink SET isEnabled = 0 WHERE ID = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Drink> SearchDrinkByName(string name) 
        {
            List<Drink> list = new List<Drink>();

            string query = string.Format("SELECT * FROM Drink WHERE isEnable = 1 AND dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                list.Add(drink);
            }

            return list;
        }
    }
}
