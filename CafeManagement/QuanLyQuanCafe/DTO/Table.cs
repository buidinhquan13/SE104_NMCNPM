using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string name, string status, int number)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
            this.Number = number;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Status = row["Status"].ToString();
            this.Number = (int)row["Number"];
        }

        private int iD;

        private string name;

        private string status;

        private int number;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Number { get => number; set => number = value; }
    }
}
