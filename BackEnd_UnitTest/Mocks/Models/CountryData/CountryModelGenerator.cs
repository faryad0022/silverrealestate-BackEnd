using Application.DTOs.Project.Country;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.CountryData
{
    public static class CountryModelGenerator
    {
        public static List<Country> countryList = new()
        {
                new Country
                {
                    Id = 1,
                    IsDelete = false,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CountryFlag = "",
                    CountryName = "Iran"
                },
                new Country
                {
                    Id = 2,
                    IsDelete = false,
                    IsSelected = true,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CountryFlag = "",
                    CountryName = "Cyprus"
                },
                new Country
                {
                    Id = 3,
                    IsDelete = false,
                    IsSelected = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    CountryFlag = "",
                    CountryName = "USA"
                }
        };
        public static CreateCountryDTO createCountryDTO_Valid = new CreateCountryDTO
        {
            CountryName = "UAE"
        };
        public static CreateCountryDTO createCountryDTO_Validation_InValid = new CreateCountryDTO
        {
            CountryName = ""
        };
        public static UpdateCountryDTO updateCountryDTO_Validation_InValid = new UpdateCountryDTO
        {
            Id = 1,
        };
        public static UpdateCountryDTO updateCountryDTO_Valid = new UpdateCountryDTO
        {
            Id = 1,
            CountryName = "Iranda"

        };
        public static UpdateCountryDTO updateCountryDTO_Validation_Notfound_InValid = new UpdateCountryDTO
        {
            Id = 5,
            CountryName = "Iranda"
        };
    }
}
