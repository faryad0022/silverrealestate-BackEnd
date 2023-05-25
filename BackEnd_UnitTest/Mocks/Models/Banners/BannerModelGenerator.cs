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
                Description="sdfsfsfg",
                Header="asdfsfsfaf",
                Id=1,
                PhoneLogo="asdfasfasf",
                RealEstateLogo="adfasdfasf",
                ShortText="asdfasffadf",
                Text="aadfasdasfas"
            },
            new Banner
            {
                Description="sasdfasdfasdfsdfdfsfsfg",
                Header="asdfsfsfaf",
                Id=2,
                PhoneLogo="asdfasdfsdfasfasf",
                RealEstateLogo="adfasdfasf",
                ShortText="asdfaqwefsdfgtrhjjksffadf",
                Text="aadfasddcfbvasdrfgwtasfas",
                IsSelected=true
            },
            new Banner
            {
                Description="sdf2341241234sfsfg",
                Header="asdfsfs12341234234faf",
                Id=3,
                PhoneLogo="asdf1234234123asfasf",
                RealEstateLogo="adf123412341234353256asdfasf",
                ShortText="asdfa12341341234sffadf",
                Text="aadfasd2341234125145asfas",
                IsSelected=true
            },
        };
        public static CreateBannerDTO createBannerDTO_Valid = new CreateBannerDTO
        {
            Description = "sdf5fghdhdfghml876tjsfsfg",
            Header = "5j5j5j5jejej",
            PhoneLogo = "asdfewe5ytthghasfasf",
            RealEstateLogo = "adfue56ujyjasdfasf",
            ShortText = "asdfsrjsrjsr5jasffadf",
            Text = "aadfasr5j65r6j5w6j5sdasfas"


        };
        public static CreateBannerDTO createBannerDTO_Validation_InValid = new CreateBannerDTO
        {
            Header = "5j5j5j5jejej",
            PhoneLogo = "asdfewe5ytthghasfasf",
            RealEstateLogo = "adfue56ujyjasdfasf",
            ShortText = "asdfsrjsrjsr5jasffadf",
            Text = "aadfasr5j65r6j5w6j5sdasfas"
        };
    }
}
