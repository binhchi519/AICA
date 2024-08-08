using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class PickingList
    {
    
        private string _itemcode;
        private string _locationcode;
        private bool _film;
        private bool _inventoryFilm;
        private int _inventoryAreaQty;
        private int _pickingID;
        private int _packingID;

        private int _outStanding;
        private String _loadingTime;
        private int _qtytoPick;
        private string _customer;
        private string _shippingPalletNo;
        private string _etd;
        private string _poPriority;



        public PickingList(/*int actionID, string actionName, */string itemcode,string location,bool film,bool iflim,int inventoryAreaQty, int pickingid,int packingid/*,int totalqtyPicked*/,int outStanding/*, int remaining*/,int qtyToPick, string customer, string shippingpalletno, string etd,string popriority)
        {
            //this.ActionID = actionID;
            //this.ActionName = actionName;
            this.ItemCode = itemcode;
            this.Location = location;
            this.Film = film;
            this.InventoryFilm = iflim;
            this.InventoryAreaQty = inventoryAreaQty;
            this.PickingID = pickingid;
            //this.PackingID = packingid;
            //this.StockQty = stockQty;
            //this.PickingQty = pickQty;
            //this.TotalQtyPicked = totalqtyPicked;
            this.OutStanding = outStanding;
            //this.Remaining = remaining;
            this.QtyToPick = qtyToPick;
            this.Customer = customer;
            this.ShippingPalletNo = shippingpalletno;
            this.ETD = etd;
            this.POPriority = popriority;


        }

        public PickingList(DataRow row)
        {
            //ActionID = Convert.ToInt32(row["ActionID"].ToString());
            //ActionName = row["ActionName"].ToString();
            ItemCode = row["ItemCode"].ToString();
            Location = row["LocationCode"].ToString();
            Film = Convert.ToBoolean(row["Film"].ToString());
            InventoryFilm = String.IsNullOrEmpty(row["InventoryFilm"].ToString())  ? false : Convert.ToBoolean(row["InventoryFilm"].ToString());
            /*   if (row["Film"].ToString()!=null)
            {

            }*/
            //InventoryFilm = row["InventoryFilm"].ToString();
            if (!String.IsNullOrEmpty(row["InventoryAreaQty"].ToString()))
            {
                InventoryAreaQty = Convert.ToInt32(row["InventoryAreaQty"].ToString());
            }
            else
            {
                InventoryAreaQty = 0;
            }
            PickingID = Convert.ToInt32(row["PickingID"].ToString());
            //PackingID = Convert.ToInt32(row["PackNo"].ToString());
            //StockQty = Convert.ToInt32(row["PickingQty"].ToString());
            //PickingQty = Convert.ToInt32(row["PickingQty"].ToString());
            if (!String.IsNullOrEmpty(row["QtyToPick"].ToString()))
            {
                QtyToPick = Convert.ToInt32(row["QtyToPick"].ToString());
            }
            else
            {
                QtyToPick = 0;
            }

            //TotalQtyPicked = Convert.ToInt32(row["TotalPicked"].ToString());
            OutStanding = Convert.ToInt32(row["OutStanding"].ToString());
            //Remaining = Convert.ToInt32(row["Remaining"].ToString());
            Customer = row["Customer"].ToString();
            ShippingPalletNo = row["ShippingPalletNo"].ToString();
            //DateTime dt = new DateTime.Now();
            /*if (row["ETD"].ToString() != null && row["ETD"].ToString().Length > 13)
            {
                String[] etdtime = new string[3];
                etdtime = row["ETD"].ToString().Split(' ')[0].Split('/');
                ETD = Int32.Parse(etdtime[1]) < 10 ? "0" + etdtime[1] + "/" : etdtime[1] + "/";
                ETD += Int32.Parse(etdtime[0]) < 10 ? "0" + etdtime[0] + "/" : etdtime[1] + "/";
                ETD += etdtime[2];
            }*/
            ETD = row["ETD"].ToString().Split(' ')[0];
            POPriority = row["POPriority"].ToString();
            LoadingTime = row["LoadingTime"].ToString();
        }

        //public int ActionID { get => _actionID; set => _actionID = value; }
        //public string ActionName { get => _actionName; set => _actionName = value; }
        public string ItemCode { get => _itemcode; set => _itemcode = value; }
        public string Location { get => _locationcode; set => _locationcode = value; }
        public bool Film { get => _film; set => _film = value; }
        public bool InventoryFilm { get => _inventoryFilm; set => _inventoryFilm = value; }
        public int PickingID { get => _pickingID; set => _pickingID = value; }
        public int InventoryAreaQty { get => _inventoryAreaQty; set => _inventoryAreaQty = value; }
        //public int PackingID { get => _packingID; set => _packingID = value; }
        //public int PickingQty { get => _pickingQty; set => _pickingQty = value; }
        public int QtyToPick { get => _qtytoPick; set => _qtytoPick = value; }
        //public int TotalQtyPicked { get => _totalqtyPicked; set => _totalqtyPicked = value; }
        public int OutStanding { get => _outStanding; set => _outStanding = value; }
        //public int Remaining { get => _remaining; set => _remaining = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public string ShippingPalletNo { get => _shippingPalletNo; set => _shippingPalletNo = value; }
        public string ETD { get => _etd; set => _etd = value; }
        public string POPriority { get => _poPriority; set => _poPriority = value; }    public string LoadingTime { get => _loadingTime; set => _loadingTime = value; }

    }
}
