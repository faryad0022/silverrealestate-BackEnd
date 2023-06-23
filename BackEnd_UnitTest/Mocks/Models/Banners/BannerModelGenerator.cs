using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.Banners
{
    public static class BannerModelGenerator
    {
        public static List<Banner> bannerList = new()
        {
            new Banner
            {
                Id=1,
                BannerImage="Banner1.jpg",
                Link="bannner/banner",
                IsSelected=true
            },
            new Banner
            {
                Id=2,
                BannerImage="Banner2.jpg",
                Link="bannner/banner",
                IsSelected=true
            },
            new Banner
            {
                Id=3,
                BannerImage="Banner3.jpg",
                Link="bannner/banner",
                IsSelected=true
            },
        };
        public static CreateBannerDTO createBannerDTO_Valid = new CreateBannerDTO
        {
            BannerImage = "Banner4.jpg",
            Link = "bannner/banner",
        };
        public static CreateBannerDTO createBannerDTO_Validation_InValid = new CreateBannerDTO
        {
            BannerImage = "",
            Link = "bannner/banner",
        };
    }
}
