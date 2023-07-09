using Application.DTOs.Project.Facility;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.Projects.Facilities
{
    public static class FacilityModelGenerator
    {
        public static List<Facility> facilityList = new()
        {
                new Facility
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false,
                    FacilityName = "استخر چهار فصل",
                    PropertyId = 1
                },
                new Facility
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false,
                    FacilityName = "استخر چهار فصل",
                    PropertyId = 2
                },
                new Facility
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false,
                    FacilityName = "زمین بازی",
                    PropertyId = 1

                },
                new Facility
                {
                    Id = 4,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false,
                    FacilityName = "رستوران",
                    PropertyId = 1
                },
                new Facility
                {
                    Id = 5,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false,
                    FacilityName = "سالن زیبایی",
                    PropertyId = 1

                }
        };
        public static CreateFacilityDTO createFacilityDTO_Valid = new CreateFacilityDTO
        {
            FacilityName = "UAE",
            PropertyId = 1

        };
        public static CreateFacilityDTO createFacilityDTO_Validation_InValid = new CreateFacilityDTO
        {
            FacilityName = "",
        };
        public static UpdateFacilityDTO updateFacilityDTO_Validation_InValid = new UpdateFacilityDTO
        {
            Id = 1,
        };
        public static UpdateFacilityDTO updateFacilityDTO_Valid = new UpdateFacilityDTO
        {
            Id = 1,
            FacilityName = "Iranda",
            PropertyId = 1
        };
        public static UpdateFacilityDTO updateFacilityDTO_Validation_Notfound_InValid = new UpdateFacilityDTO
        {
            Id = 50,
            FacilityName = "Iranda"
        };
    }
}
