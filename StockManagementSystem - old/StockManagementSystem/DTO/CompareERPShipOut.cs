using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class CompareERPShipOut
    {
        private DateTime _shipOutDate;
        private string _itemCode;
        private string _itemCodeERP;
        private int _stockQuantity;
        private int _ERPData;
        private int _differrence;
        private string _customer;

        public CompareERPShipOut(DateTime stockInDate, string itemCode, string itemCodeERP, int stockQuantity, int eRPData, int differrence)
        {
            ShipOutDate = stockInDate;
            ItemCode = itemCode;
            ItemCodeERP = itemCodeERP;
            Quantity = stockQuantity;
            ERPData = eRPData;
            Differrence = differrence;
        }

        public CompareERPShipOut(DataRow row)
        {
            ShipOutDate = DateTime.Parse(row["ShipOutDate"].ToString());
            Customer = row["Customer"].ToString();
            ItemCode = !String.IsNullOrEmpty(row["ItemCode"].ToString()) ? row["ItemCode"].ToString() : ""; 
            ItemCodeERP = row["ERPItem"].ToString();
            Quantity = !String.IsNullOrEmpty(row["TotalQty"].ToString()) ? Convert.ToInt32(row["TotalQty"].ToString()) : 0;
            ERPData = !String.IsNullOrEmpty(row["ERPData"].ToString()) ? Convert.ToInt32(row["ERPData"].ToString()) : 0;
            Differrence = !String.IsNullOrEmpty(row["TotalQty"].ToString()) ? Convert.ToInt32(row["TotalQty"].ToString()) - Convert.ToInt32(row["ERPData"].ToString()) : 0;
               
        }

        public DateTime ShipOutDate { get => _shipOutDate; set => _shipOutDate = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string ItemCodeERP { get => _itemCodeERP; set => _itemCodeERP = value; }
         public string Customer { get => _customer; set => _customer = value; }
        public int Quantity { get => _stockQuantity; set => _stockQuantity = value; }
        public int ERPData { get => _ERPData; set => _ERPData = value; }
        public int Differrence { get => _differrence; set => _differrence = value; }
    }
}
