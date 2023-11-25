using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.API.Data
{
    public class HotelDescription
    {
        #region Public Properties
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
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
