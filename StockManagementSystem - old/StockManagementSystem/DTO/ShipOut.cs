using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class ShipOut
    {
        //private DateTime _stockInDate;
        private DateTime _stockOutDate;
        private string _poNo;
        private string _customer;
        private string _itemCode;
        private string _palletNo;
        private int _quantity;
        private string _loadingTime;
        private String _PIC;
        public ShipOut(DataRow row)
        {
            //StockInDate = DateTime.Parse(row["PackedDate"].ToString());
            ShipOutDate = !String.IsNullOrEmpty(row["ShipOutDate"].ToString())?DateTime.Parse(row["ShipOutDate"].ToString()): DateTime.MaxValue;
            PONO = row["PoNo"].ToString();
            Customer = row["Customer"].ToString();
            ItemCode = row["ItemCode"].ToString();
            ShippingPalletNo = row["ShippingPalletNo"].ToString();
            Quantity = Convert.ToInt32(row["PackedQty"].ToString());
            LoadingTime = row["LoadingTime"].ToString(); 
        }

        public ShipOut(DateTime stockInDate, DateTime stockoutDate,string pono, string customer, string itemCode, string palletNo, int quantity,string loadingtime)
        {

           // StockInDate = stockInDate;
            ShipOutDate = stockoutDate;
            PONO = pono;
            Customer = customer;
            ItemCode = itemCode;
            ShippingPalletNo = palletNo;
            Quantity = quantity;
            LoadingTime = loadingtime;
        }
        //public DateTime StockInDate { get => _stockInDate; set => _stockInDate = value; }
        public DateTime ShipOutDate { get => _stockOutDate; set => _stockOutDate = value; }
        public string PONO { get => _poNo; set => _poNo = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string ShippingPalletNo { get => _palletNo; set => _palletNo = value; }
       
        public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        //public String PIC { get => _PIC; set => _PIC = value; }
    }
}
