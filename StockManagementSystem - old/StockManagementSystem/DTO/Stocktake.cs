using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class Stocktake
    {
        private int _actionid;
        private string _actionname;
        private string _itemcode;
        private string _palletno;
        private string _location;
        private int _qty;
        private int _actualqty;
        private bool _enough;
        private bool _isCheck;
        private DateTime _includedTime;

        public Stocktake(int actionid,string actionname,string itemcode,string palletno, string location, int qty, int actualqty, bool enough, bool isCheck,DateTime includedTime)
        {
            Actionid = actionid;
            Actionname = actionname;
            Itemcode = itemcode;
            Palletno = palletno;
            Location = location;
            Qty = qty;
            Actualqty = actualqty;
            Enough = enough;
            IsCheck = isCheck;
            IncludedTime = includedTime;
        }
        public Stocktake(DataRow row)
        {
            Actionid = Convert.ToInt32(row["ActionID"].ToString());
            Actionname = row["ActionName"].ToString();
            Itemcode = row["ItemCode"].ToString();
            Palletno = row["PalletNo"].ToString();
            Location = row["LocationCode"].ToString();
            Qty = Convert.ToInt32(row["Qty"].ToString());
            Actualqty = Convert.ToInt32(row["ActualQty"].ToString());
            if(!String.IsNullOrEmpty(row["Enough"].ToString()))
            {
                Enough = Boolean.Parse(row["Enough"].ToString());
            }
            else
            {
                Enough = false;
            }    
            if(!String.IsNullOrEmpty(row["isChecked"].ToString()))
            {
                IsCheck = Boolean.Parse(row["isChecked"].ToString());
            }
            else
            {
                IsCheck = false;
            }    
            
            IncludedTime= DateTime.Parse(row["IncludedTime"].ToString());
        }
        public string Itemcode { get => _itemcode; set => _itemcode = value; }
        public string Palletno { get => _palletno; set => _palletno = value; }
        public string Location { get => _location; set => _location = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public int Actualqty { get => _actualqty; set => _actualqty = value; }
        public bool Enough { get => _enough; set => _enough = value; }
        public bool IsCheck { get => _isCheck; set => _isCheck = value; }
        public DateTime IncludedTime { get => _includedTime; set => _includedTime = value; }
        public int Actionid { get => _actionid; set => _actionid = value; }
        public string Actionname { get => _actionname; set => _actionname = value; }
    }
}
