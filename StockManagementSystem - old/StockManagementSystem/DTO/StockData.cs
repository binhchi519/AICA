using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class StockData
    {
        //private int _actionID;
        //private string _actionName;
        private string _itemCode;
        //private string _itemCodeERP;
        private string _palletNo;
        private string _inventoryQuantity;private string _locationCode;
        private DateTime? _stockInDate;
        private int? _backLog;

        public StockData(/*int actionID, string actionName,*/string itemCode, /*string itemCodeERP,*/ string palletNo, string inventoryQuantity, DateTime? stockInDate, int? backLog)
        {
            //ActionID = actionID;
            //ActionName = actionName;
            ItemCode = itemCode;
            //ItemCodeERP = itemCodeERP;
            PalletNo = palletNo;
            InventoryQuantity = inventoryQuantity;
            StockInDate = stockInDate;
            BackLog = backLog;
        }

        public StockData(DataRow row)
        {

            //ActionID = Convert.ToInt32(row["ActionID"].ToString());
            //ActionName = row["ActionName"].ToString();
            ItemCode = row["ItemCode"].ToString(); LocationCode = row["LocationCode"].ToString();
            //ItemCodeERP = row["ERPItem"].ToString();
            PalletNo = row["PalletNo"].ToString();
            InventoryQuantity = row["inventoryQty"].ToString();
            if (!String.IsNullOrEmpty(row["StockInDate"].ToString()))
            {
                StockInDate = DateTime.Parse(row["StockInDate"].ToString());
            }

            //StockInDate = DateTime.Parse(row["StockInDate"].ToString());
            if(!String.IsNullOrEmpty(row["BackLog"].ToString()))
            {
                BackLog = Convert.ToInt32(row["BackLog"].ToString());
            }
            else
            {
                BackLog = 0;
            }    
        }
        //public int ActionID { get => _actionID; set => _actionID = value; }
        //public string ActionName { get => _actionName; set => _actionName = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        //public string ItemCodeERP { get => _itemCodeERP; set => _itemCodeERP = value; }
        public string PalletNo { get => _palletNo; set => _palletNo = value; }
        public string InventoryQuantity { get => _inventoryQuantity; set => _inventoryQuantity = value; }
        public string LocationCode { get => _locationCode; set => _locationCode = value; }
        public DateTime? StockInDate { get => _stockInDate; set => _stockInDate = value; }
        public int? BackLog { get => _backLog; set => _backLog = value; }
    }
}
