using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.API.Data
{
    public class HotellDescription
    {
        #region Public Properties        
        public int Id { get; set; }

        #region Optiional fileds

        public bool? HasSpa { get; set; }
        public bool? HasNonSmokingRooms { get; set; }
        public bool? HasFitnessCenter { get; set; }
        public bool? FreeWiFi { get; set; }

        public bool? PrivateParking { get; set; }  
        #endregion

        #endregion
    }
}
