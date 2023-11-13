using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using QuanLyQuanCafe.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO? instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password) 
        {
            string encodedUsername = Encode(username);
            string encodedPassword = Encode(password);

            string query = "USP_Login @username , @password";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {encodedUsername, encodedPassword});

            return result.Rows.Count > 0;
        }

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

        public Account? GetAccountByUsername(string username) 
        {
            string encodedUsername = Encode(username);

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE Username = '" + encodedUsername + "'");
            
            foreach (DataRow row in data.Rows) 
            {
                row["Username"] = Decode(row["Username"].ToString());
                return new Account(row);
            }

            return null;
        }

        public bool UpdateAccount(string username, string displayName, string pass, string newPass)
        {
            string encodedUsername = Encode(username);
            string encodedPassword = Encode(pass);
            string encodedNewPass = Encode(newPass);

            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @username , @displayName , @password , @newPassword", new object[] { encodedUsername, displayName, encodedPassword, encodedNewPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            DataTable table =  DataProvider.Instance.ExecuteQuery("SELECT Username, DisplayName, Type FROM Account");

            foreach (DataRow row in table.Rows) 
            {
                row["Username"] = Decode(str: row["Username"].ToString());
            }

            return table;
        }

        public bool AddAccount(string name, string display, int type)
        {
            string encodedUsername = Encode(name);

            string query = string.Format("INSERT Account (Username, DisplayName, Type) VALUES (N'{0}', N'{1}', N'{2}')", encodedUsername, display, type);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string username, string display, int type)
        {
            string encodedUsername = Encode(username);

            string query = string.Format("Update Account SET DisplayName = N'{1}', Type = {2} WHERE Username = N'{0}'", encodedUsername, display, type);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string encodedUsername = Encode(username);

            string query = string.Format("DELETE Account WHERE Username = N'{0}'", encodedUsername);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string encodedUsername = Encode(name);

            string query = string.Format("UPDATE Account SET Password = N'MA==' WHERE Username = N'{0}'", encodedUsername);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
