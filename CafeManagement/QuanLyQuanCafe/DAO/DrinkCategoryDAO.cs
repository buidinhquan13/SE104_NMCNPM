using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class DrinkCategoryDAO
    {
        private static DrinkCategoryDAO? instance;

        public static DrinkCategoryDAO? Instance 
        {
            get { if (instance == null) instance = new DrinkCategoryDAO(); return instance; }
            private set => instance = value; 
        }

        private DrinkCategoryDAO() { }

        public List<DrinkCategory> GetListCategory()
        {
            List<DrinkCategory> list = new List<DrinkCategory>();

            string query = "SELECT * FROM DrinkCategory WHERE isEnabled = 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows) 
            {
                DrinkCategory category = new DrinkCategory(item);
                list.Add(category);
            }

            return list;
        }

        public DrinkCategory GetCategoryByID(int id) 
        {
            DrinkCategory? category = null;

            string query = "SELECT * FROM DrinkCategory WHERE ID = " + id + "AND isEnabled = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows) 
            {
                category = new DrinkCategory(item);

                return category;
            }

            return category;
        }

        public bool AddDrinkCategory(string name)
        {
            string query = string.Format("INSERT DrinkCategory (Name) VALUES (N'{0}')", name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDrinkCategory(int id, string name)
        {
            string query = string.Format("UPDATE DrinkCategory SET Name = N'{1}' WHERE ID = {0}", id, name);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDrinkCategory(int id) 
        {
            List<Drink> list = DrinkDAO.Instance.GetListDrinkByCategoryID(id);
            
            foreach (Drink drink in list) 
            {
                DrinkDAO.Instance.DeleteDrink(drink.ID);
            }

            string query = string.Format("UPDATE DrinkCategory SET isEnabled = 0 WHERE ID = {0}", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
