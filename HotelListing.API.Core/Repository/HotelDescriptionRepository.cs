using AutoMapper;
using HotelListing.API.Core.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Core.Repository
{
    public class HotelDescriptionRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelDescriptionRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
