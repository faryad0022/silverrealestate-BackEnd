using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Domain.Entities.GeneralSiteInformation;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.RealEstateService
{
    public static class RealEstateServicesModelGenerator
    {
        public static List<RealEstateServices> RealEstateServicesList = new()
        {
            new ()
            {
                Id=1,
                Description="adsadasdad",
                CreateDate=DateTime.Now,
                IsDelete=false,
                ImageName="asdasdasdasd",
                Name="asdasdsadfwefwe"
            },
            new ()
            {
                Id=2,
                Description="adsadasdad",
                CreateDate=DateTime.Now,
                IsDelete=false,
                IsSelected=true,
                ImageName="mojgan",
                Name="mojgan"
            },
            new ()
            {
                Id=3,
                Description="adsadasdad",
                CreateDate=DateTime.Now,
                IsDelete=false,
                ImageName="faryad",
                IsSelected=true,
                Name="faryad"
            },
            new ()
            {
                Id=4,
                Description="adsadasdad",
                CreateDate=DateTime.Now,
                IsDelete=true,
                ImageName="asdasdmojasdasd",
                IsSelected=true,
                Name="asdasdsadfwefweFARYAD"
            }
        };

        public static RealEstateServicesDTO realEstateServicesDTO = new()
        {
            Id = 3,
            ImageName = "faryad",
            Name = "faryad"
        };
        public static CreateRealEstateServicesDTO createRealEstateServicesDTO_Valid = new()
        {
            Description = "adsadasdad",
            ImageName = "faryad",
            Name = "faryad"
        };
        public static CreateRealEstateServicesDTO createRealEstateServicesDTO_InValid_NameRequired = new()
        {
            Description = "adsadasdad",
            ImageName = "faryad",
        };
        public static UpdateRealEstateServicesDTO updateRealEstateServicesDTO_Valid = new()
        {
            Id = 1,
            Description = "adsadasdad",
            ImageName = "faryad",
            Name = "faryad"
        };
        public static UpdateRealEstateServicesDTO updateRealEstateServicesDTO_InValid_NotFound = new()
        {
            Id = 10,
            Description = "adsadasdad",
            ImageName = "faryad",
            Name = "faryad"
        };
        public static UpdateRealEstateServicesDTO updateRealEstateServicesDTO_InValid_ValidationError = new()
        {
            Id = 1,
            Description = "adsadasdad",
            ImageName = "faryad",
            Name = ""
        };

    }
}
