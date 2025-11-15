using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Core.Models.Country;
using HotelListing.API.Core.Models.Hotel;
using HotelListing.API.Core.Models.Users;
using HotelListing.API.Core.Models.HotelDescription;

namespace HotelListing.API.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            #region County Mapping
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            #endregion

            #region Hotel Mapping
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            #endregion

            #region ApiUser Mapping
            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
            #endregion

            #region HotelDescription Mapping
            CreateMap<HotelDescription, CreateHotelDescriptionDto>().ReverseMap();
            CreateMap<HotelDescription, HotelDescriptionDto>().ReverseMap();
            //CreateMap<HotelDescription, ApiUser>().ReverseMap();
            //CreateMap<HotelDescription, ApiUser>().ReverseMap();
            #endregion
        }
    }
}
