using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Confirgurations
{
    public class HotelDescriptionConfiguration : IEntityTypeConfiguration<HotelDescription>
    {
        public void Configure(EntityTypeBuilder<HotelDescription> builder)
        {
            builder.HasData(
                new HotelDescription
                {
                   Id = 1,
                   HasSpa = true
                }
            ); ;
        }
    }
}
