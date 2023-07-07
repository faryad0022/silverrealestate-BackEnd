using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.General.Socials
{
    public static class SocialModelGenerator
    {
        public static List<Social> socialList = new()
        {
                new Social
                {
                    Id = 1,
                    Icon="fa-facebook",
                    Link="www.facebook.com",
                    Name="Facebook",
                    IsSelected=true
                },
                new Social
                {
                    Id = 2,
                    Icon="fa-instagram",
                    Link="www.facebook.com",
                    Name="Instaram"
                }
            };
        public static CreateSocialDTO _createSocialDTO = new CreateSocialDTO
        {
            Icon = "fa-twitter",
            Link = "twitter.com",
            Name = "Twitter"
        };

        public static UpdateSocialDTO _updateSocialDTO_Valid = new UpdateSocialDTO
        {
            Id = 1,
            Icon = "fa-twitter rtuu",
            Link = "twitter.com",
            Name = "Twitter"
        };
        public static UpdateSocialDTO _updateSocialDTO_ValidationError_InValid = new UpdateSocialDTO
        {
            Id = 1,
            Icon = "",
            Link = "twitter.com",
            Name = "Twitter"
        };
        public static UpdateSocialDTO _updateSocialDTO_NotFound_InValid = new UpdateSocialDTO
        {
            Id = 100,
            Icon = "fa-facebook",
            Link = "twitter.com",
            Name = "Twitter"
        };

    }
}
