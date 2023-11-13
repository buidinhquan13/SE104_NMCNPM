using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Customer
    {
        private string username;
        private DateTime? registerDate;
        private float point;

        public string Username { get => username; set => username = value; }
        public DateTime? RegisterDate { get => registerDate; set => registerDate = value; }
        public float Point { get => point; set => point = value; }

        public Customer(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.RegisterDate = (DateTime)row["RegisterDate"];
            this.Point = (float)Convert.ToDouble(row["Point"]);
        }
    }
}
