using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class InventoryArea
    {
        private string _itemCode;
        private string _location;
        private int _qty;

        public InventoryArea(string itemCode, string location, int qty)
        {
            ItemCode = itemCode;
            Location = location;
            Qty = qty;
        }

        public InventoryArea(DataRow row)
        {
            ItemCode = row["ItemCode"].ToString();
            Location = row["LocationCode"].ToString();
            Qty = Convert.ToInt32(row["Qty"].ToString());
        }

        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public string Location { get => _location; set => _location = value; }
        public int Qty { get => _qty; set => _qty = value; }
    }
}
