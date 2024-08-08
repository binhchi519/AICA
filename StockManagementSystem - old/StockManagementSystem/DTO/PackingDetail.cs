using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class PackingDetail
    {
        private int _id;
        //private int _packingID;
        private DateTime _ETD;
        private string _PODetailID;
        private string _itemCode;
        private int _packqty;
        private int _PackedQty;
        private string _shippaletno;
        private string _loadingTime;
        private string _pickeddate;
        private string _packeddate;
        private string _shipoutdate;
        private string _status;

        public PackingDetail(/*int id, DateTime eTD, string pODetailID, string itemCode, int packqty, int packedQty, string shippaletno, string loadingTime, string pickeddate, string packeddate,*/ string shipoutdate/*, string status*/)
        {
            //_id = id;
            //_ETD = eTD;
            //_PODetailID = pODetailID;
            //_itemCode = itemCode;
            //_packqty = packqty;
            //_PackedQty = packedQty;
            //_shippaletno = shippaletno;
            //_loadingTime = loadingTime;
            //_pickeddate = pickeddate;
            //_packeddate = packeddate;
            _shipoutdate = shipoutdate;
            //_status = status;
        }
        public PackingDetail(DataRow row)
        {
            //String[] etdtime = new string[3];
            //Id = Convert.ToInt32(row["ID"].ToString());
            //ETD = DateTime.Parse(row["ETD"].ToString());
            ////Packqty = row["POno"].ToString();
            //ItemCode = row["ItemCode"].ToString();
            //Packqty = Convert.ToInt32(row["PackQty"].ToString());
            //PackedQty = Convert.ToInt32(row["PackedQty"].ToString());
            Shippaletno = row["ShippingPalletNo"].ToString();
            //LoadingTime = row["LoadingTime"].ToString();

            //if (!row["PickedDate"].ToString().Equals(""))
            //{
            //    Pickeddate = row["PickedDate"].ToString();
            //    /*String[] swapTime = new string[3];
            //    String[] date = new string[3];
            //    swapTime = row["PickedDate"].ToString().Split(' ');
            //    date = swapTime[0].Split('/');
            //    PickedDate = Int32.Parse(date[1]) < 10 ? "0" + date[1] + "/" : date[1] + "/";
            //    PickedDate += Int32.Parse(date[0]) < 10 ? "0" + date[0] + "/" : date[0] + "/";
            //    PickedDate += date[2] + " " + swapTime[1];*/
            //}

            //if (!row["PackedDate"].ToString().Equals(""))
            //{
            //    Packeddate = row["PackedDate"].ToString();
            //    /* String[] swapTime = new string[3];
            //     String[] date = new string[3];
            //     swapTime = row["PackedDate"].ToString().Split(' ');
            //     date = swapTime[0].Split('/');
            //     PackedDate = Int32.Parse(date[1]) < 10 ? "0" + date[1] + "/" : date[1] + "/";
            //     PackedDate += Int32.Parse(date[0]) < 10 ? "0" + date[0] + "/" : date[0] + "/";
            //     PackedDate += date[2] + " " + swapTime[1];*/
            //}
            //if (row["ETD"].ToString() != null && row["ETD"].ToString().Length > 13)
            //{
            //    Shipoutdate = row["ETD"].ToString().Split(' ')[0];
            //    /* etdtime = (row["ETD"].ToString().Split(' '))[0].Split('/');
            //     ShipoutDate = Int32.Parse(etdtime[1]) < 10 ? "0" + etdtime[1] + "/" : etdtime[1] + "/"; 
            //     ShipoutDate += Int32.Parse(etdtime[0]) < 10 ? "0" + etdtime[0] + "/" : etdtime[1] + "/";
            //     ShipoutDate += etdtime[2];*/
            //}
            //else
            //{
            //    Shipoutdate = "";

            //}
            //PODetailID = row["PODetailID"].ToString();
            //Status = row["PackingStatus"].ToString();
        }

        //public int Id { get => _id; set => _id = value; }
        //public DateTime ETD { get => _ETD; set => _ETD = value; }
        //public string PODetailID { get => _PODetailID; set => _PODetailID = value; }
        //public string ItemCode { get => _itemCode; set => _itemCode = value; }
        //public int Packqty { get => _packqty; set => _packqty = value; }
        //public int PackedQty { get => _PackedQty; set => _PackedQty = value; }
        public string Shippaletno { get => _shippaletno; set => _shippaletno = value; }
        //public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }
        //public string Pickeddate { get => _pickeddate; set => _pickeddate = value; }
        //public string Packeddate { get => _packeddate; set => _packeddate = value; }
        //public string Shipoutdate { get => _shipoutdate; set => _shipoutdate = value; }
        //public string Status { get => _status; set => _status = value; }
    }
}
