using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.About
{
    public static class AboutUsModelGenerator
    {
        public static List<AboutUs> aboutUs = new()
        {
            new AboutUs
            {
                Id = 1,
                IsSelected = true,
                TeamImage="asdfasdfsdfsasdfafasdfa",
                Text="asdfasfasdfasfasdfasdfasdfasdfasdfasdfasdfasdfasd",
                IsDelete=false,
            }

        };
        public static List<AboutUs> emptyAboutUsList = new() { };
        public static CreateAboutUsDTO createAboutUsDTO_Valid = new()
        {
            Text = "asdfasdfsfasdfasdfgsdfgsfdgfsdfasdf",
            TeamImage = "asdfadfasdfasdfasdfasdff"
        };
        public static UpdateAboutUsDTO updateAboutUsDTO_Valid = new()
        {
            Id=1,
            Text = "asdfasdfsfasdfasdfgsdfghdfghdfghdfghdfghddfgsfdgfsdfasdf",
            TeamImage = "asdfadfasdfasdfasdfgdfghdfghdfasdff"
        };
        public static UpdateAboutUsDTO updateAboutUsDTO_InValid = new()
        {
            Id = 1,
            Text = "asdfasdff",
            TeamImage = "asdfadfasdfasdfasdfasdff"
        };
        public static UpdateAboutUsDTO updateAboutUsDTO_NotFound_InValid = new()
        {
            Id = 2,
            Text = "asdfalkjhlkjhkljhkljhkljhlkjhkljhlkjhljksdff",
            TeamImage = "asdfadfasdfasdfasdfasdff"
        };
        public static CreateAboutUsDTO createAboutUsDTO_Validation_InValid = new()
        {
            Text = "gsfdgfsdfasdf",
            TeamImage = "asdfadfasdfasdfasdfasdff"
        };
    }
}
