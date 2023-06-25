using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogGroup;
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
using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Application.Models.FilterModels;
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
            CreateMap<BlogGroupDTO, UpdateBlogGroupDTO>().ReverseMap();
            CreateMap<BlogGroupDTO, CreateBlogGroupDTO>().ReverseMap();

            CreateMap<BlogContent, BlogContentDTO>()
                .ForMember(dest => dest.BlogGroupName, opt => opt.MapFrom(src => src.blogGroup.Name))
                .ReverseMap();
            CreateMap<BlogContent, BlogContentListDTO>()
                .ForMember(dest => dest.BlogGroupName, opt => opt.MapFrom(src => src.blogGroup.Name))
                .ReverseMap();
            CreateMap<BlogContent, CreateBlogContentDTO>().ReverseMap();
            CreateMap<BlogContent, UpdateBlogContentDTO>().ReverseMap();
            CreateMap<BlogContentDTO, UpdateBlogContentDTO>().ReverseMap();
            CreateMap<BlogContentDTO, CreateBlogContentDTO>().ReverseMap();
            CreateMap<FilterBlogContent, FilterBlogContentDTO>()
                .ForMember(dest => dest.BlogContentList, opt =>
                {
                    opt.MapFrom(src => src.BlogContentList);
                })
                .ReverseMap();


            #endregion

            #region AboutUs
            CreateMap<AboutUs, AboutUsDTO>().ReverseMap();
            CreateMap<AboutUs, CreateAboutUsDTO>().ReverseMap();
            CreateMap<AboutUs, UpdateAboutUsDTO>().ReverseMap();
            CreateMap<AboutUsDTO, UpdateAboutUsDTO>().ReverseMap();
            CreateMap<AboutUsDTO, CreateAboutUsDTO>().ReverseMap();

            #endregion

            #region Address
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<Address, UpdateAddressDTO>().ReverseMap();
            CreateMap<Address, CreateAddressDTO>().ReverseMap();
            CreateMap<AddressDTO, UpdateAddressDTO>().ReverseMap();
            CreateMap<AddressDTO, CreateAddressDTO>().ReverseMap();

            #endregion

            #region Social
            CreateMap<Social, SocialDTO>().ReverseMap();
            CreateMap<Social, CreateSocialDTO>().ReverseMap();
            CreateMap<Social, UpdateSocialDTO>().ReverseMap();
            CreateMap<SocialDTO, CreateSocialDTO>().ReverseMap();
            CreateMap<SocialDTO, UpdateSocialDTO>().ReverseMap();
            #endregion

            #region ConstructorInformatio
            CreateMap<ConstructorInformation, ConstructorInformationDTO>().ReverseMap();
            CreateMap<ConstructorInformation, CreateConstructorInformationDTO>().ReverseMap();
            CreateMap<ConstructorInformation, UpdateConstructorInformationDTO>().ReverseMap();
            CreateMap<ConstructorInformationDTO, CreateConstructorInformationDTO>().ReverseMap();
            CreateMap<ConstructorInformationDTO, UpdateConstructorInformationDTO>().ReverseMap();
            #endregion

            #region CommonQuestion
            CreateMap<CommonQuestion, CommonQuestionDTO>().ReverseMap();
            CreateMap<CommonQuestion, CreateCommonQuestionDTO>().ReverseMap();
            CreateMap<CommonQuestion, UpdateCommonQuestionDTO>().ReverseMap();
            CreateMap<CommonQuestionDTO, CreateCommonQuestionDTO>().ReverseMap();
            CreateMap<CommonQuestionDTO, UpdateCommonQuestionDTO>().ReverseMap();
            #endregion

            #region RealEsateServices
            CreateMap<RealEstateServices, RealEstateServicesDTO>().ReverseMap();
            CreateMap<RealEstateServices, CreateRealEstateServicesDTO>().ReverseMap();
            CreateMap<RealEstateServices, UpdateRealEstateServicesDTO>().ReverseMap();
            CreateMap<RealEstateServicesDTO, CreateRealEstateServicesDTO>().ReverseMap();
            CreateMap<RealEstateServicesDTO, UpdateRealEstateServicesDTO>().ReverseMap();
            #endregion

            #region Banner
            CreateMap<Banner, BannerDTO>().ReverseMap();
            CreateMap<Banner, CreateBannerDTO>().ReverseMap();
            CreateMap<Banner, UpdateBannerDTO>().ReverseMap();
            CreateMap<BannerDTO, CreateBannerDTO>().ReverseMap();
            CreateMap<BannerDTO, UpdateBannerDTO>().ReverseMap();
            CreateMap<FilterBanner, FilterBannerDTO>()
                .ForMember(dest => dest.BannerDTOs, opt =>
                {
                    opt.MapFrom(src => src.Banners);
                })
                .ReverseMap();

            #endregion

            #region Logo
            CreateMap<Logo, LogoDTO>().ReverseMap();
            CreateMap<Logo, CreateLogoDTO>().ReverseMap();
            CreateMap<Logo, UpdateLogoDTO>().ReverseMap();
            CreateMap<LogoDTO, CreateLogoDTO>().ReverseMap();
            CreateMap<LogoDTO, UpdateLogoDTO>().ReverseMap();
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

            #region TeamMember
            CreateMap<TeamMember, TeamMemberDTO>().ReverseMap();
            CreateMap<TeamMember, CreateTeamMmeberDTO>().ReverseMap();
            CreateMap<TeamMember, UpdateTeamMemberDTO>().ReverseMap();
            CreateMap<TeamMemberDTO, CreateTeamMmeberDTO>().ReverseMap();
            CreateMap<TeamMemberDTO, UpdateTeamMemberDTO>().ReverseMap();
            CreateMap<FilterTeamMember, FilterTeamMemberDTO>()
                .ForMember(dest => dest.TeamMembersDTO, opt =>
                {
                    opt.MapFrom(src => src.TeamMembers);
                })
                .ReverseMap();
            #endregion


        }
    }
}
