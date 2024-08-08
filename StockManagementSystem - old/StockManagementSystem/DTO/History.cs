using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class History
    {
        private string _workingdate2;
        private string _pic;
        private string _item;
        private string _palletno;
        private string _location;
        private int _qty;
        private int _afterQty;
        private DateTime _dateTime;
       
public History( string workingdate2, string pic, string item, string palletno, string location, int qty, int afterQty, DateTime dateTime )
        {
   
            Workingdate2 = workingdate2;
            Pic = pic;
            Item = item;
            Palletno = palletno;
            Location = location;
            Qty = qty;
            AfterQty = afterQty;
            DateTime = dateTime;
       
        }
        public History (DataRow row )
        {
         
            Workingdate2 = row["ActionName"].ToString();
            Pic = row["PersonInCharge"].ToString();
            Item = row["ItemCode"].ToString();
            Palletno = row["PalletNo"].ToString();
            Location = row["locationCode"].ToString();
            if(!String.IsNullOrEmpty(row["HistoryQty"].ToString()))
                {
                Qty = Convert.ToInt32(row["HistoryQty"].ToString());
            }
            else
            {
                Qty = 0;
            }    
            if(!String.IsNullOrEmpty(row["AfterQty"].ToString()))
            {
                AfterQty = Convert.ToInt32(row["AfterQty"].ToString());

            }
            else
            {
                AfterQty = 0;
            }
            DateTime = DateTime.Parse(row["UpdateTime"].ToString());
        }
        public string Workingdate2 { get => _workingdate2; set => _workingdate2 = value; }
        public string Pic { get => _pic; set => _pic = value; }
        public string Item { get => _item; set => _item = value; }
        public string Palletno { get => _palletno; set => _palletno = value; }
        public string Location { get => _location; set => _location = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public int AfterQty { get => _afterQty; set => _afterQty = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
       
    }
}
