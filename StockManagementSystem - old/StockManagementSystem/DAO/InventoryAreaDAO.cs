using StockManagementSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DAO
{
    public class InventoryAreaDAO
    {
        private static InventoryAreaDAO _instance;

        public static InventoryAreaDAO Instance
        {
            get { if (_instance == null) _instance = new InventoryAreaDAO(); return InventoryAreaDAO._instance; }
            private set { InventoryAreaDAO._instance = value; }
        }

        private InventoryAreaDAO() { }

        public List<InventoryArea> GetInventorybyItem(string items)
        {
            List<InventoryArea> list = new List<InventoryArea>();
            string query = "GetTotalQtyByArea @ItemCode";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { items});
            foreach (DataRow item in data.Rows)
            {
                InventoryArea inventoryArea = new InventoryArea(item);
                list.Add(inventoryArea);
            }
            return list;
        }
            public bool UpdatePickList(DateTime ETD, int PackNo)
        {
            string query = "UpdatePKLETD @ETD , @PackNo";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ETD, PackNo });
            return result > 0;
        }
        public bool InsertPickArea(int PickingID, string Location,int QtytoPick,string Item)
        {
            string query = "upsertPickArea @PickingID , @LocationCode , @QtyToPick , @ItemCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PickingID, Location, QtytoPick, Item });
            return result >0;
        }
        public bool UpdateOutstanding(int PickingID, int Outstanding)
        {
            string query = "updatePickingList @PickingID , @OutStanding";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { PickingID, Outstanding});
            return result > 0;
        }

    }
}
