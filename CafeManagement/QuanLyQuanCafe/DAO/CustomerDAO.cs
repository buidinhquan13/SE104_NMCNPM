using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO? instance;

        public static CustomerDAO? Instance 
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set => instance = value; 
        }

        private CustomerDAO() { }

        public string Decode(string str)
        {
            byte[] bytes = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        public string Encode(string text)
        {
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textBytes);
        }

        public List<Customer> LoadListCustomer()
        {
            List<Customer> list = new List<Customer>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCustomerList");
            foreach (DataRow row in data.Rows) 
            {
                Customer customer = new Customer(row);
                customer.Username = Decode(customer.Username).ToString();
                list.Add(customer);
            }

            return list;
        }

        public bool AddCustomer(string name)
        {
            string encodedName = Encode(name);

            string query = string.Format("INSERT Customer (Username) VALUES (N'{0}')", encodedName);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCustomer(string name) 
        {
            string encodedName = Encode(name);

            string query = string.Format("DELETE Customer WHERE Username = N'{0}'", encodedName);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public Customer SearchCustomerByUsername(string name)
        {
            string encodedName = Encode(name);

            string query = string.Format("SELECT * FROM Customer WHERE Username = N'{0}'", encodedName);

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows) 
            {
                Customer cus = new Customer(row);

                cus.Username = Decode(cus.Username).ToString();

                return cus;
            }

            return null;
        }

        public void UpdatePoint(string name, float point)
        {
            string encodedName = Encode(name);

            string query = string.Format("UPDATE Customer SET Point = {1} WHERE Username = N'{0}'", encodedName, point);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
