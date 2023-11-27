using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.API.Core.Models.HotelDescription
{
    public class HotelDescriptionDto
    {
       
        
        #region Optiional fileds

        public bool? HasSpa { get; set; }
        public bool? HasNonSmokingRooms { get; set; }
        public bool? HasFitnessCenter { get; set; }
        public bool? FreeWiFi { get; set; }

        public bool? PrivateParking { get; set; }
        #endregion
    }
}
