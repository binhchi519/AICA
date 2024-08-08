using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class PackingList
    {
        //private int _actionID;
        //private string _actionName;
        private int _id;
        //private int _packingID;
        private string _podetailID;
        private string _customer;
        private DateTime _podate;
        private string _pono;
        private string _itemCode;
        private bool _flim;
        private int _packqty;
        private string _shippaletno;
        private string _loadingTime;
        private string _pickeddate;
        private string _packeddate;
        private string _shipoutdate;
        private string _status;

        public PackingList(/*int actionID, string actionName,*/int id/*,int packingid*/,string podetailID, string customer, DateTime podate,string pono,string itemcode,bool flim, int packqty,string shippaletno,string loadingTime, string pickeddate, string packeddate,string shipoutdate,string status)
        {
            //ActionID = actionID;
            //ActionName = actionName;
            this.ID = id;
            //this.PackingID = packingid;
            this.Customer = customer;
            this.PODate = podate;
            this.PONo = pono;
            this.ItemCode = itemcode;
            this.Flim = flim;
            this.PackQty = packqty;
            this.ShipPalletNo = shippaletno;
            this.LoadingTime = loadingTime;
            this.PickedDate = pickeddate;
            this.PackedDate = packeddate;
            this.ShipoutDate = shipoutdate;
            this.PODeatailID = podetailID;
            this.Status = status;

        }

        public PackingList(DataRow row)
        {
            String[] etdtime = new string[3];
            ID = Convert.ToInt32(row["ID"].ToString());
            Customer = row["Customer"].ToString();
            PODate = DateTime.Parse(row["PoDate"].ToString());
            PONo = row["POno"].ToString();
            ItemCode = row["ItemCode"].ToString();
            Flim = Convert.ToBoolean(row["Film"].ToString());
            PackQty = Convert.ToInt32(row["PackQty"].ToString());
            ShipPalletNo = row["ShippingPalletNo"].ToString();
            LoadingTime = row["LoadingTime"].ToString();
          
            if (!row["PickedDate"].ToString().Equals(""))
            {
                PickedDate=row["PickedDate"].ToString();
                /*String[] swapTime = new string[3];
                String[] date = new string[3];
                swapTime = row["PickedDate"].ToString().Split(' ');
                date = swapTime[0].Split('/');
                PickedDate = Int32.Parse(date[1]) < 10 ? "0" + date[1] + "/" : date[1] + "/";
                PickedDate += Int32.Parse(date[0]) < 10 ? "0" + date[0] + "/" : date[0] + "/";
                PickedDate += date[2] + " " + swapTime[1];*/
            }

            if (!row["PackedDate"].ToString().Equals(""))
            {
                PackedDate = row["PackedDate"].ToString();
               /* String[] swapTime = new string[3];
                String[] date = new string[3];
                swapTime = row["PackedDate"].ToString().Split(' ');
                date = swapTime[0].Split('/');
                PackedDate = Int32.Parse(date[1]) < 10 ? "0" + date[1] + "/" : date[1] + "/";
                PackedDate += Int32.Parse(date[0]) < 10 ? "0" + date[0] + "/" : date[0] + "/";
                PackedDate += date[2] + " " + swapTime[1];*/
            }
            if (row["ETD"].ToString() != null && row["ETD"].ToString().Length> 13 && Convert.ToInt32(row["PackingStatus"].ToString()) >=1)

            {
                ShipoutDate = row["ETD"].ToString().Split(' ')[0];
                /* etdtime = (row["ETD"].ToString().Split(' '))[0].Split('/');
                 ShipoutDate = Int32.Parse(etdtime[1]) < 10 ? "0" + etdtime[1] + "/" : etdtime[1] + "/"; 
                 ShipoutDate += Int32.Parse(etdtime[0]) < 10 ? "0" + etdtime[0] + "/" : etdtime[1] + "/";
                 ShipoutDate += etdtime[2];*/
            }
            else {
                ShipoutDate ="";

            }
            PODeatailID = row["PODetailID"].ToString();
            Status = row["PackingStatus"].ToString();
        }

        //public int ActionID { get => _actionID; set => _actionID = value; }
        //public string ActionName { get => _actionName; set => _actionName = value; }
        public int ID { get => _id; set => _id = value; }
        //public int PackingID { get => _packingID; set => _packingID = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public DateTime PODate { get => _podate; set => _podate = value; }
        public string PONo { get => _pono; set => _pono = value; }
        public string ItemCode { get => _itemCode; set => _itemCode = value; }
        public bool Flim { get => _flim; set => _flim = value; }
        public int PackQty { get => _packqty; set => _packqty = value; }
        public string ShipPalletNo { get => _shippaletno; set => _shippaletno = value; }
        public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
        public string PickedDate { get => _pickeddate; set => _pickeddate = value; }
        public string PackedDate { get => _packeddate; set => _packeddate = value; }
        public string ShipoutDate { get => _shipoutdate; set => _shipoutdate = value; }
        public string PODeatailID { get => _podetailID; set => _podetailID = value; }
        public string Status { get => _status; set => _status = value; }

    }
}
