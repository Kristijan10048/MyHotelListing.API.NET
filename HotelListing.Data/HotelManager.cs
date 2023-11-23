using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.API.Data
{
    public class HotelManager
    {
        #region Public propertis    
        
        public int Id { get; set; }
        public string FirstName { get; set; }= string.Empty;    
        public string LastName { get; set; } = string.Empty;

        public string PhoneNumber {  get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } 
        public string City { get; set; }    
        public string Region { get; set; }  
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; }
        #endregion

    }
}
