using Application.DTOs.Project.City;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.Projects.Cities
{
    public static class CityModelGenerator
    {
        public static List<City> citylList = new()
        {
                new City
                {
                    Id = 1,
                    IsDelete = false,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CityName = "Kish",
                    CountryId = 1,
                },
                new City
                {
                    Id = 2,
                    IsDelete = false,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CityName = "Tehran",
                    CountryId = 1,
                },
                new City
                {
                    Id = 3,
                    IsDelete = false,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CityName = "Iskele",
                    CountryId = 2,
                },
                new City
                {
                    Id = 4,
                    IsDelete = false,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CityName = "Girne",
                    CountryId = 2,
                }
        };


        public static CreateCityDTO _createCityDTO_Valid = new()
        {
            CityName = "Tabriz",
            CountryId = 1,
        };
        public static CreateCityDTO _createCityDTO_ValidationError_NotExist_Invalid = new CreateCityDTO
        {
            CityName = "Tabriz",
            CountryId = 10,
        };
        public static CreateCityDTO _createCityDTO_ValidationError_Invalid = new CreateCityDTO
        {
            CityName = "",
            CountryId = 1,
        };
        public static CreateCityDTO _createCityDTO_ValidationError_Duplicate_Invalid = new CreateCityDTO
        {
            CityName = "Kish",
            CountryId = 2,
        };


        public static UpdateCityDTO _updateCityDTO_Valid = new()
        {
            Id = 1,
            CityName = "Kish1",
            CountryId = 1,
        };
        public static UpdateCityDTO _updateCityDTO_ValidationError_InValid = new UpdateCityDTO
        {
            Id = 1,
            CityName = "",
            CountryId = 1,
        };
        public static UpdateCityDTO _updateCityDTO_ValidationError_CityNotFound_InValid = new UpdateCityDTO
        {
            Id = 10,
            CityName = "Kish1",
            CountryId = 1,
        };
        public static UpdateCityDTO _updateCityDTO_ValidationError_CountryNotFound_InValid = new UpdateCityDTO
        {
            Id = 1,
            CityName = "Kish1",
            CountryId = 10,
        };
        public static UpdateCityDTO _updateCityDTO_ValidationError_Duplicate_InValid = new UpdateCityDTO
        {
            Id = 1,
            CityName = "Kish",
            CountryId = 1,
        };

    }
}
