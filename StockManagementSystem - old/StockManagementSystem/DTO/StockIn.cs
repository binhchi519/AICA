using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace StockManagementSystem.DTO
{
    public class StockIn
    {
       // private int _actionID;
       // private string _actionName;
        private DateTime _stockInDate;
        private string _itemCode;
        //private string _itemCodeERP;
        private string _palletNo;
        private string _locationCode;
        private int _quantity;
        private string _updateTime;
        private string _PIC;
        public StockIn(DataRow row)
        {
            //ActionID = Convert.ToInt32(row["ActionID"].ToString());
            //ActionName = row["ActionName"].ToString();
            if (row["StockInDate"].ToString() != null)
            {
                StockInDate = DateTime.Parse(row["StockInDate"].ToString().Split(' ')[0]);
            }
            ItemCode = row["ItemCode"].ToString();
            PalletNo = row["PalletNo"].ToString();
            LocationCode = row["locationCode"].ToString();
            Quantity = Convert.ToInt32(row["Qty"].ToString());
            if (row["UpdateTime"].ToString() != null)
            {
                UpdateTime = row["UpdateTime"].ToString();
            }
             if (row["PIC"].ToString() != null)
            {
                PIC = row["PIC"].ToString();
               
            }
        }

        public StockIn( int actionID,/* string actionName, */DateTime stockInDate, string itemCode,  string palletNo, string locationCode, int quantity, string updateTime)
        {
           // ActionID = actionID;
           // ActionName = actionName;
            StockInDate = stockInDate;
            ItemCode = itemCode;
            PalletNo = palletNo;
            LocationCode = locationCode;
            Quantity = quantity;
            UpdateTime = updateTime;
        }

       // public int ActionID { get => _actionID; set => _actionID = value; }
      //  public string ActionName { get => _actionName; set => _actionName = value; }
        public DateTime StockInDate { get => _stockInDate; set => _stockInDate = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string PalletNo { get => _palletNo; set => _palletNo = value; }
        public string LocationCode { get => _locationCode; set => _locationCode = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string UpdateTime { get => _updateTime; set => _updateTime = value; } 
        public string PIC { get => _PIC; set => _PIC = value; }
    }
}
