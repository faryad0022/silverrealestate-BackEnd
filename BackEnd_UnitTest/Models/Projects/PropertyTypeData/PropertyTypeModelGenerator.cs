using Application.DTOs.Project.PropertyType;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Models.Projects.PropertyTypeData
{
    public static class PropertyTypeModelGenerator
    {
        public static List<PropertyType> propertyTypeList = new()
        {
                new PropertyType
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Type = "آپارتمان"
                },
                new PropertyType
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Type = "ویلا"
                },
                new PropertyType
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Type = "زمین"
                }
        };
        public static CreatePropertyTypeDTO createPropertyTypeDTO_Valid = new CreatePropertyTypeDTO
        {
            Type = "سرمایه گذاری"
        };
        public static CreatePropertyTypeDTO createPropertyTypeDTO_Validation_InValid = new CreatePropertyTypeDTO
        {
            Type = ""
        };
        public static UpdatePropertyTypeDTO updatePropertyTypeDTO_Validation_InValid = new UpdatePropertyTypeDTO
        {
            Id = 1,
        };
        public static UpdatePropertyTypeDTO updatePropertyTypeDTO_Valid = new UpdatePropertyTypeDTO
        {
            Id = 1,
            Type = "Iranda"

        };
        public static UpdatePropertyTypeDTO updatePropertyTypeDTO_Validation_Notfound_InValid = new UpdatePropertyTypeDTO
        {
            Id = 50,
            Type = "Iranda"
        };
    }
}
