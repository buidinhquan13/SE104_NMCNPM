using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        private string drinkName;

        private int count;

        private float price;

        private float total;

        public string DrinkName { get => drinkName; set => drinkName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float Total { get => total; set => total = value; }

        public Menu(string name, int count, float price, float total = 0) 
        {
            this.DrinkName = name;
            this.Count = count;
            this.Price = price;
            this.Total = total;
        }

        public Menu(DataRow row)
        {
            this.DrinkName = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Total = (float)Convert.ToDouble(row["total"].ToString());
        }
    }
}
