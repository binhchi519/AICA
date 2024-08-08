using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DTO;

namespace StockManagementSystem.DAO
{
    public class LocationDAO
    {
        private static LocationDAO _instance;

        public static LocationDAO Instance
        {
            get { if (_instance == null) _instance = new LocationDAO(); return LocationDAO._instance; }
            private set { LocationDAO._instance = value; }
        }

        private LocationDAO() { }

        public List<Location> GetListLocation()
        {
            List<Location> list = new List<Location>();
            string query = "GetAllLocations";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Location location = new Location(item);
                list.Add(location);
            }
            return list;
        }

        public List<Location> GetListLocationByLocationCode(string LocationCode)
        {
            List<Location> list = new List<Location>();
            string query = "GetLocationByLocationCode @locationCode";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { LocationCode });
            foreach (DataRow item in data.Rows)
            {
                Location location = new Location(item);
                list.Add(location);
            }
            return list;
        }

        public bool InsertAndUpdateLocation(string locationCode, string locationName)
        {
            string query = "UpsertLocation @locationCode , @locationName";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { locationCode, locationName });
            return result > 0;
        }

        public bool DeleteLocation(string locationCode)
        {
            string query = "DeleteLocation @locationCode";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { locationCode });
            return result > 0;
        }
    }
}
