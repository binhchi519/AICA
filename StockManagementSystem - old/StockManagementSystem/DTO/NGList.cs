using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class NGList
    {
        //private DateTime _workingdate1;
        private string _workingdate2;
        private string _pic;
        private string _item;
        private string _palletno;
        private string _location;
        private int _qty;
        private int _afterQty;
        private DateTime dateTime;
        private string _lossname;
public NGList(/*DateTime workingdate1,*/ string workingdate2, string pic, string item, string palletno, string location, int qty, int afterQty, DateTime dateTime,string lossname)
        {
            //Workingdate1 = workingdate1;
            Workingdate2 = workingdate2;
            Pic = pic;
            Item = item;
            Palletno = palletno;
            Location = location;
            Qty = qty;
            AfterQty = afterQty;
            DateTime = dateTime;
            Lossname = lossname;
        }
        public NGList(DataRow row )
        {
            //Workingdate1 = DateTime.Parse(row["StockInDate"].ToString());
            Workingdate2 = row["ActionName"].ToString();
            Pic = row["PersonInCharge"].ToString();
            Item = row["ItemCode"].ToString();
            Palletno = row["PalletNo"].ToString();
            Location = row["locationCode"].ToString();
            if(!String.IsNullOrEmpty(row["LossQty"].ToString()))
                {
                Qty = Convert.ToInt32(row["LossQty"].ToString());
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
            if (!String.IsNullOrEmpty(row["lrLoss"].ToString()))
            {
                Lossname = row["lrLoss"].ToString();

            }
            else
            {
                Lossname = "";
            }
            //Lossname = row["LossReasonCode"].ToString();
            DateTime = DateTime.Parse(row["UpdateTime"].ToString());
        }
        //public DateTime Workingdate1 { get => _workingdate1; set => _workingdate1 = value; }
        public string Workingdate2 { get => _workingdate2; set => _workingdate2 = value; }
        public string Pic { get => _pic; set => _pic = value; }
        public string Item { get => _item; set => _item = value; }
        public string Palletno { get => _palletno; set => _palletno = value; }
        public string Location { get => _location; set => _location = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public int AfterQty { get => _afterQty; set => _afterQty = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Lossname { get => _lossname; set => _lossname = value; }
    }
}
