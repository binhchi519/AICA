using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class StockDataTotal
    {
        private string _itemCode;
        private string _qty;
        private bool _film;
        private string _backLog;

        public StockDataTotal(string itemCode, string inventoryQuantity)
        {
            ItemCode = itemCode;
            InventoryQuantity = inventoryQuantity;
        }

        public StockDataTotal(DataRow row)
        {
            ItemCode = row["ItemCode"].ToString();
            InventoryQuantity = row["TotalQty"].ToString();
            if (!row["BACKLOG"].ToString().Equals("")) {
                BackLog =row["BACKLOG"].ToString();
            }
            else
            {
                BackLog = "0";
            }
           Film = Boolean.Parse(String.IsNullOrWhiteSpace(row["Film"].ToString())?"FALSE": row["Film"].ToString().Length==0?"FALSE": row["Film"].ToString());


        }
        public String ItemCode { get => _itemCode; set => _itemCode = value; }
        public string InventoryQuantity { get => _qty; set => _qty = value; }  
        public String BackLog { get => _backLog; set => _backLog = value; }
        public bool Film { get => _film; set => _film = value; }
    }
}
