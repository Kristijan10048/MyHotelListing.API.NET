using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Data
{
    /// <summary>
    /// Model class for Hotel
    /// </summary>s
    public class Hotel
    {
        # region Public Properties/table columnsf
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
       
		public int NumberOfRooms { get; set; }

        #region Protected optional properties
        /// <summary>
        /// Hotel WebSite optional ?
        /// </summary>
        public string? WebSite { get; set; }

        public string? PhoneNumber { get; set; }
        #endregion

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }


        public virtual IList<HotelManager> HotelManagers { get; set; }
        #endregion
    }
}
