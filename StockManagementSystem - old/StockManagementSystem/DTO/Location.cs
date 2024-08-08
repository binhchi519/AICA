using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StockManagementSystem.DTO
{
    public class Location
    {
        private string _locationCode;
        private string _locationName;

        public Location(string locationCode, string locationName)
        {
            LocationCode = locationCode;
            LocationName = locationName;
        }

        public Location(DataRow row)
        {
            LocationCode = row["LocationCode"].ToString();
            LocationName = row["LocationName"].ToString();
        }

        public string LocationCode { get => _locationCode; set => _locationCode = value; }
        public string LocationName { get => _locationName; set => _locationName = value; }
    }
}
