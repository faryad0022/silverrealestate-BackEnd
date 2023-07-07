using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.General.Logos
{
    public class LogoModelGenerator
    {
        public static List<Logo> LogoList = new()
        {
            new Logo
            {
                Id=1,
                ImageName="asdasdasdsdasd",
                IsSelected=true,
                Title="asdfadfasdfadf"
            },
            new Logo
            {
                Id=2,
                ImageName="asdasdasdasasrfwe",
                IsSelected=false,
                Title="asdfaasdfsdfsddfasdfadf"
            },
        };
        public static LogoDTO logoDTO = new LogoDTO
        {
            Id = 1,
            ImageName = "asdasdasdsdasd",
            Title = "asdfadfasdfadf"
        };
        public static CreateLogoDTO createDTO_Valid = new CreateLogoDTO
        {
            Description = "jhjhgjhgjhgjj",
            ImageName = "asdasdasdsdasd",
            Title = "asdfadfasdfadf"
        };
        public static CreateLogoDTO createDTO_InValid = new CreateLogoDTO
        {
            ImageName = "",
            Title = "asdfadfasdfadf"
        };




    }
}
