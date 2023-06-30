using AutoMapper;
using RealEstateUI.Models;
using RealEstateUI.Services.Base;

namespace RealEstateUI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddressDTO, AddressVM>().ReverseMap();
            CreateMap<ConstructorInformationDTO, ConstructorVM>().ReverseMap();

        }
    }
}
