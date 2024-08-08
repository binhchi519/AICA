using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class CompareERPStockTake
    {
     /*   private DateTime _stockInDate;*/
        private string _itemCode;
        private string _itemCodeERP;
        private int _stockQuantity;
        private int _ERPData;
        private int _differrence;

        public CompareERPStockTake(/*DateTime stockInDate,*/ string itemCode, string itemCodeERP, int stockQuantity, int eRPData, int differrence)
        {
           /* StockInDate = stockInDate;*/
            ItemCode = itemCode;
            ItemCodeERP = itemCodeERP;
            Quantity = stockQuantity;
            ERPData = eRPData;
            Differrence = differrence;
        }

        public CompareERPStockTake(DataRow row)
        {
          /*  StockInDate = DateTime.Parse(row["StockInDate"].ToString());*/
            ItemCode = row["ItemCode"].ToString();
            ItemCodeERP = row["ERPItem"].ToString();
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

       /* public DateTime StockInDate { get => _stockInDate; set => _stockInDate = value; }*/
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string ItemCodeERP { get => _itemCodeERP; set => _itemCodeERP = value; }
        public int Quantity { get => _stockQuantity; set => _stockQuantity = value; }
        public int ERPData { get => _ERPData; set => _ERPData = value; }
        public int Differrence { get => _differrence; set => _differrence = value; }
    }
}
