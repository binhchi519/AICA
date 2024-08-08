using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class ShipOutDAO
    {
        private static ShipOutDAO _instance;

        public static ShipOutDAO Instance
        {
            get { if (_instance == null) _instance = new ShipOutDAO(); return ShipOutDAO._instance; }
            private set { ShipOutDAO._instance = value; }
        }

        private ShipOutDAO() { }

        public List<ShipOut> GetListShipOut()
        {
            List<ShipOut> list = new List<ShipOut>();
            string query = "getAllShipOut";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ShipOut shipOut = new ShipOut(item);
                list.Add(shipOut);
            }
            return list;
        }
        public List<ShipOut> GetNGList()
        {
            List<ShipOut> list = new List<ShipOut>();
            string query = "Select * from Loss Order By ACtionID DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ShipOut shipOut = new ShipOut(item);
                list.Add(shipOut);
            }
            return list;
        }
    }
}
