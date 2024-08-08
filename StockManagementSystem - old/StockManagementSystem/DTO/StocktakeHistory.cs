using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class StocktakeHistory
    {
      //  private string _itemcode;
        private string _erpItemcode;
        private int _qty;
        private int _erpQty;
        private DateTime _createdDate;
        private DateTime _updateTime;
        private int _diffQty;
        public StocktakeHistory(DataRow row)
        {
        //    Itemcode =row["ItemCode"].ToString();
            ERPItemcode = row["ERPItemCode"].ToString();
            InventoryQty = String.IsNullOrEmpty(row["TotalQty"].ToString())?0:Int32.Parse(row["TotalQty"].ToString());
            ERPQty = Int32.Parse(row["ERPQty"].ToString());
            CreatedDate = DateTime.Parse(row["CreatedDate"].ToString());
            UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
            Difference = InventoryQty - ERPQty;
        }
     //   public string Itemcode { get => _itemcode; set => _itemcode = value; }
        public string ERPItemcode { get => _erpItemcode; set => _erpItemcode = value; }
        public int InventoryQty { get => _qty; set => _qty = value; }
        public int ERPQty { get => _erpQty; set => _erpQty = value; }
        public int Difference { get => _diffQty; set => _diffQty = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public DateTime UpdateTime { get => _updateTime; set => _updateTime = value; }

    }
}
