using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        private int iD;
        private int iDBill;
        private int iDDrink;
        private int total;

        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDDrink { get => iDDrink; set => iDDrink = value; }
        public int Total { get => total; set => total = value; }

        public BillInfo(int id, int idBill, int idDrink, int total) 
        { 
            this.ID = id;
            this.IDBill = idBill;
            this.IDDrink = idDrink;
            this.Total = total;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDBill = (int)row["IDBill"];
            this.IDDrink = (int)row["IDDrink"];
            this.Total = (int)row["Total"];
        }
    }
}
