using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.ConstructorInformations
{
    public static class ConstructorInformationModelGenerator
    {
        public static List<ConstructorInformation> constructorInformationList = new()
        {
            new ConstructorInformation
            {
                Id = 1,
                ConstructorLogo="xhxhxgxdfgfdg",
                Description="sdfsfgdsdsdggf",
                Title="sdfasdfasf",
                IsSelected = true
            },
            new ConstructorInformation
            {
                Id = 2,
                ConstructorLogo="xhxhasdfklsjdfjasd;fljxgxdfgfdg",
                Description="sdfsfgds234109238  dsdggf",
                Title="sdfdf'lvskvj'lasdfasf",
                IsSelected = false
            },
            new ConstructorInformation
            {
                Id = 3,
                ConstructorLogo="xhxh1111111111111111xgxdfgfdg",
                Description="sdfsfgd2222222222222222sdsdggf",
                Title="sdfa33333333333333sdfasf",
                IsSelected = false
            },
        };
        public static CreateConstructorInformationDTO createConstructorInformationDTO_Valid = new CreateConstructorInformationDTO
        {
            Description = "sdf5fghdhdfghml876tjsfsfg",
            Title = "dfghdfghdfghdfgh",
            ConstructorLogo = "sdsdfgsdgsdfgsd"


        };
        public static CreateConstructorInformationDTO createConstructorInformationDTO_Validation_InValid = new CreateConstructorInformationDTO
        {
            Description = "sdf5fghdhdfghml876tjsfsfg",
            Title = "dfghdfghdfghdfgh",
        };
        public static UpdateConstructorInformationDTO updateConstructorInformationDTO_Validation_InValid = new UpdateConstructorInformationDTO
        {
            Id = 1,
            Description = "sdf5fghdhdfghml876tjsfsfg",
            Title = "dfghdfghdfghdfgh",
        };
        public static UpdateConstructorInformationDTO updateConstructorInformationDTO_Valid = new UpdateConstructorInformationDTO
        {
            Id = 1,
            Description = "sdf5fghdhdsdfsdfsdfghml876tjsfsfg",
            Title = "dfghdfghdfghdfgh",
            ConstructorLogo = "sdsdfgsdgsdfgsd"

        };
        public static UpdateConstructorInformationDTO updateConstructorInformationDTO_Notfound_InValid = new UpdateConstructorInformationDTO
        {
            Id = 5,
            Description = "sdf5fghdhdsdfsdfsdfghml876tjsfsfg",
            Title = "dfghdfghdfghdfgh",
            ConstructorLogo = "sdsdfgsdgsdfgsd"

        };
    }
}
