using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Drink
    {
        private int iD;
        private string name;
        private int iDCategory;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public float Price { get => price; set => price = value; }

        public Drink(int id, string name, int idCategory, float price) 
        { 
            this.ID = id;
            this.Name = name;
            this.IDCategory = idCategory;
            this.Price = price;
        }

        public Drink(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
