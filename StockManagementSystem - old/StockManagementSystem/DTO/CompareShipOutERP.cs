using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class CompareShipOutERP
    {
        private DateTime _shipOutDate;
        private string _itemCode;
        private string _itemCodeERP;
        private string _customer;
        private string _poNo;
        private int _stockQuantity;
        private int _ERPData;
        private int _differrence;

        public CompareShipOutERP(DateTime stockInDate, string itemCode, string itemCodeERP, int stockQuantity, int eRPData, int differrence)
        {
            ShipOutDate = stockInDate;
            ItemCode = itemCode;
            ItemCodeERP = itemCodeERP;
            Quantity = stockQuantity;
            ERPData = eRPData;
            Differrence = differrence;
        }

        public CompareShipOutERP(DataRow row)
        {
            ShipOutDate = DateTime.Parse(row["StockInDate"].ToString());
            ItemCode = row["ItemCode"].ToString();
            ItemCodeERP = row["ERPItem"].ToString(); 
          

            if (String.IsNullOrEmpty(row["PONO"].ToString()))
            {
                PONO = "";
            }
            else
            {
                PONO = row["PONO"].ToString();
            }
            if (String.IsNullOrEmpty(row["Customer"].ToString()))
            {
                Customer = "";
            }
            else
            {
                Customer =  row["Customer"].ToString();
            }


            if (String.IsNullOrEmpty(row["TotalQty"].ToString()))
            {
                Quantity = 0;
            }    
            else
            {
                Quantity = Convert.ToInt32(row["TotalQty"].ToString());
            }
            if (String.IsNullOrEmpty(row["ERPData"].ToString()))
            {
                ERPData = 0;
            }
            else
            {
                ERPData = Convert.ToInt32(row["ERPData"].ToString());
            }
            if (String.IsNullOrEmpty(row["Different"].ToString()))
            {
                Differrence = Convert.ToInt32(row["ERPData"].ToString())*-1;
               
            }
            else
            {
                Differrence = Convert.ToInt32(row["Different"].ToString());

            }
            
        }

        public DateTime ShipOutDate { get => _shipOutDate; set => _shipOutDate = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; } 
        public string PONO { get => _poNo; set => _poNo = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public string ItemCodeERP { get => _itemCodeERP; set => _itemCodeERP = value; }
        public int Quantity { get => _stockQuantity; set => _stockQuantity = value; }
        public int ERPData { get => _ERPData; set => _ERPData = value; }
        public int Differrence { get => _differrence; set => _differrence = value; }
    }
}
