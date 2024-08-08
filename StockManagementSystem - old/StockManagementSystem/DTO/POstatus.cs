using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DTO
{
    public class POstatus
    {
        private string _poNo;
        private DateTime _poDate;
        private string _customer;
        private string _itemCode;
        private bool _film;
        private int _POqty;
        private int _pStock;
        private int _picking;
        private int _masking;
        private int _packing;
        private int _allstock;
        private int _backlog;
        private int _shippingqty; 
        private int _packStatus;
        public POstatus() { }
        public POstatus( string pono, DateTime podate, string customer, string item, bool film, int POqty, int POstock, int Picking, int Masking, int Packing, int Allstock, int Backlog,int shippingqty)
        {
            this.PONo = pono;
            this.PODate = podate;
            this.Customer = customer;
            this.Item = item;
            this.Film = film;
            this.POQty = POqty;
            this.PStock = POstock;
            this.Picking = Picking;
            this.Masking = Masking;
            this.Packing = Packing;
            this.AllStock = Allstock;
            this.Backlog = Backlog;
            this.ShippingQty = shippingqty;

        }
        public POstatus(DataRow row)
        {
            //ID = row["ID"].ToString();
            PONo = row["POno"].ToString();
            PODate = DateTime.Parse(row["PoDate"].ToString());
            Customer = row["Custommer"].ToString();
            Item = row["ItemCode"].ToString();
            Film = Boolean.Parse(row["Film"].ToString());
            


            if (!String.IsNullOrEmpty(row["PSTOCK"].ToString()))
            {
                PStock = Convert.ToInt32(row["PSTOCK"].ToString());
            }
            else
            {
                PStock = 0;
            }
             if (!String.IsNullOrEmpty(row["PICKEDQTY"].ToString()))
            {
                _picking = Convert.ToInt32(row["PICKEDQTY"].ToString());
            }
            else
            {
                _picking = 0;
            }
             if (!String.IsNullOrEmpty(row["MASKINGQTY"].ToString()))
            {
                Masking = Convert.ToInt32(row["MASKINGQTY"].ToString());
            }
            else
            {
                Masking = 0;
            }

            if (!String.IsNullOrEmpty(row["PACKEDQTY"].ToString()))
            {
                Packing = Convert.ToInt32(row["PACKEDQTY"].ToString());
            }
            else
            {
                Packing = 0;
            }

            if (!String.IsNullOrEmpty(row["ALLSTOCK"].ToString()))
            {
                AllStock = Convert.ToInt32(row["ALLSTOCK"].ToString());
            }
            else
            {
                AllStock = 0;
            }
         /*   if (!String.IsNullOrEmpty(row["POQty"].ToString()))
            {
                POQty = Convert.ToInt32(row["POQty"].ToString());
            }
            else
            {
                POQty = 0;
            }*/

         /*   if (!String.IsNullOrEmpty(row["SHIPOUTED"].ToString()))
            {

                Backlog = POQty - Convert.ToInt32(row["SHIPOUTED"].ToString());
            }
            else
            {
                Backlog = POQty;
            }*/
            if (!String.IsNullOrEmpty(row["PackingStatus"].ToString() ))
            {
               
                    PackingStatus = Convert.ToInt32(row["PackingStatus"].ToString());
            }
            else
            {
                PackingStatus = 0;
            }
            if (!String.IsNullOrEmpty(row["SHIPOUTED"].ToString()))
            {

                ShipOutted = Convert.ToInt32(row["SHIPOUTED"].ToString());
            }
            else
            {
                ShipOutted = 0;
            }
            if (!String.IsNullOrEmpty(row["ShippingQty"].ToString()))
            {
                POQty = Convert.ToInt32(row["ShippingQty"].ToString());
            }
            else
            {
                POQty = 0;
            }
           


            if (!String.IsNullOrEmpty(row["ShippingQty"].ToString()))
            {

                ShippingQty = Convert.ToInt32(row["ShippingQty"].ToString());
            }
            else
            {
                ShippingQty = 0;
            }
            //Backlog = POQty - ShipOutted;
        }
        public string PONo { get => _poNo; set => _poNo = value; }
        public DateTime PODate { get => _poDate; set => _poDate = value; }
        public string Customer { get => _customer; set => _customer = value; }
        public string Item { get => _itemCode; set => _itemCode = value; }
        public bool Film { get => _film; set => _film = value; }
        public int POQty { get => _POqty; set => _POqty = value; }
        public int PStock { get => _pStock; set => _pStock = value; }
        public int Picking { get => _picking; set => _picking = value; }
        public int Masking { get => _masking; set => _masking = value; }
        public int Packing { get => _packing; set => _packing = value; }
        public int AllStock { get => _allstock; set => _allstock = value; }
        public int Backlog { get => _backlog; set => _backlog = value; }
        public int ShippingQty { get => _shippingqty; set => _shippingqty = value; }
        public int PackingStatus { get => _packStatus; set => _packStatus = value; }
        private int _shipOutted;
        public int ShipOutted { get => _shipOutted; set => _shipOutted = value; }
    }
    
}
