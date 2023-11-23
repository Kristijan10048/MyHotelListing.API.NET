namespace HotelListing.API.Data
{
 
    /// <summary>
    /// Model for coutry
    /// </summary>
    public class Country
    {
        #region Public Properties/table columns
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        //public string PhoneCode { get; set; }   
        #endregion

        public virtual IList<Hotel> Hotels { get; set; }
    }
}