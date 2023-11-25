using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Confirgurations
{
    public class HotelManagerConfiguration : IEntityTypeConfiguration<HotelManager>
    {
        public void Configure(EntityTypeBuilder<HotelManager> builder)
        {
            builder.HasData(
                new HotelManager
                {
                    Id = -1,
                    FirstName = "Test1",
                    LastName = "Testovski",
                    PhoneNumber = "1234567890",
                    Email = "test@test.com",
                    City = "SomeCity",
                    Region = "SomeRegion",
                    PostalCode = "12345",
                    Address = "Some street",
                    Country = "SomeContry",
                    //Country = new Country(),
                    HotelId = 1
                }
            ); ;
        }
    }
}
