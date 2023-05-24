using Application.Const.Filters;
using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogGroup;
using Application.DTOs.Filters;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using AutoMapper;
using Domain.Entities.Blog;
using Domain.Entities.GeneralSiteInformation;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Blog Profile Section
            CreateMap<BlogGroup, BlogGroupDTO>().ReverseMap();
            CreateMap<BlogGroup, CreateBlogGroupDTO>().ReverseMap();
            CreateMap<BlogGroup, UpdateBlogGroupDTO>().ReverseMap();

            CreateMap<BlogContent, BlogContentDTO>()
                .ForMember(dest => dest.BlogGroupName, opt => opt.MapFrom(src => src.blogGroup.Name))
                .ReverseMap();
            CreateMap<BlogContent, BlogContentListDTO>()
                .ForMember(dest => dest.BlogGroupName, opt => opt.MapFrom(src => src.blogGroup.Name))
                .ReverseMap();
            CreateMap<BlogContent, CreateBlogContentDTO>().ReverseMap();
            CreateMap<BlogContent, UpdateBlogContentDTO>().ReverseMap();

            #endregion

            #region AboutUs
            CreateMap<AboutUs, AboutUsDTO>().ReverseMap();
            CreateMap<AboutUs, CreateAboutUsDTO>().ReverseMap();
            CreateMap<AboutUs, UpdateAboutUsDTO>().ReverseMap();

            #endregion

            #region Address
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Address, UpdateAddressDTO>().ReverseMap();
            CreateMap<Address, CreateAddressDTO>().ReverseMap();

            #endregion

            #region Social
            CreateMap<Social, SocialDTO>().ReverseMap();
            CreateMap<Social, CreateSocialDTO>().ReverseMap();
            CreateMap<Social, UpdateSocialDTO>().ReverseMap();
            #endregion

            #region ConstructorInformatio
            CreateMap<ConstructorInformation, ConstructorInformationDTO>().ReverseMap();
            CreateMap<ConstructorInformation, CreateConstructorInformationDTO>().ReverseMap();
            CreateMap<ConstructorInformation, UpdateConstructorInformationDTO>().ReverseMap();
            #endregion

            #region CommonQuestion
            CreateMap<CommonQuestion, CommonQuestionDTO>().ReverseMap();
            CreateMap<CommonQuestion, CreateCommonQuestionDTO>().ReverseMap();
            CreateMap<CommonQuestion, UpdateCommonQuestionDTO>().ReverseMap();
            #endregion

            #region RealEsateServices
            CreateMap<RealEstateServices, RealEstateServicesDTO>().ReverseMap();
            CreateMap<RealEstateServices, CreateRealEstateServicesDTO>().ReverseMap();
            CreateMap<RealEstateServices, UpdateRealEstateServicesDTO>().ReverseMap();
            #endregion

            #region Banner
            CreateMap<Banner, BannerDTO>().ReverseMap();
            CreateMap<Banner, CreateBannerDTO>().ReverseMap();
            CreateMap<Banner, UpdateBannerDTO>().ReverseMap();
            #endregion

            #region Logo
            CreateMap<Logo, LogoDTO>().ReverseMap();
            CreateMap<Logo, CreateLogoDTO>().ReverseMap();
            CreateMap<Logo, UpdateLogoDTO>().ReverseMap();
            #endregion

            #region Filters
            CreateMap<FilterBlogContent, FilterBlogContentDTO>()
                .ReverseMap();
            #endregion

            #region SpectacularLocation
            CreateMap<Spectacularlocation, SpectacularLocationDTO>().ReverseMap();
            CreateMap<Spectacularlocation, CreateSpectacularLocationDTO>().ReverseMap();
            CreateMap<Spectacularlocation, UpdateSpectacularLocationDTO>().ReverseMap();
            CreateMap<SpectacularLocationDTO, UpdateSpectacularLocationDTO>().ReverseMap();
            CreateMap<SpectacularLocationDTO, CreateSpectacularLocationDTO>().ReverseMap();
            #endregion

            #region SpectacularLocationImage
            CreateMap<SpectacularLocationImages, SpectacularLocationImagesDTO>()
                .ForMember(dest => dest.SpectacularlocationName, opt =>
                {
                    opt.MapFrom(src => src.Spectacularlocation.Name);
                })
                .ForMember(dest => dest.SpectacularlocationId, opt =>
                {
                    opt.MapFrom(src => src.Spectacularlocation.Id);
                });

            CreateMap<SpectacularLocationImages, CreateSpectacularLocationImagesDTO>()
                .ForMember(dest => dest.SpectacularlocationName, opt =>
                {
                    opt.MapFrom(src => src.Spectacularlocation.Name);
                })
                .ForMember(dest => dest.SpectacularlocationId, opt =>
                {
                    opt.MapFrom(src => src.Spectacularlocation.Id);
                }).ReverseMap();

            CreateMap<SpectacularLocationImagesDTO, CreateSpectacularLocationImagesDTO>().ReverseMap();


            CreateMap<SpectacularLocationImages, UpdateSpectacularLocationImagesDTO>()
                .ForMember(dest => dest.SpectacularlocationName, opt =>
                {
                    opt.MapFrom(src => src.Spectacularlocation.Name);
                })
                .ForMember(dest => dest.SpectacularlocationId, opt =>
                {
                    opt.MapFrom(src => src.Spectacularlocation.Id);
                }).ReverseMap();
            CreateMap<SpectacularLocationImagesDTO, UpdateSpectacularLocationImagesDTO>().ReverseMap();

            #endregion

        }
    }
}
