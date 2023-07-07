using Application.DTOs.Project.PropertyContractType;
using Domain.Entities.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_UnitTest.Models.Projects.PropertyContractTypeData
{
    public static class PropertyContractTypeModelGenerator
    {
        public static List<PropertyContractType> propertyContractTypeList = new List<PropertyContractType>
        {
                new PropertyContractType
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ContractType = "فروش"
                },
                new PropertyContractType
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ContractType = "اجاره"
                },
                new PropertyContractType
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    ContractType = "پیش فروش"
                }
        };
        public static CreatePropertyContractTypeDTO createPropertyContractTypeDTO_Valid = new CreatePropertyContractTypeDTO
        {
            ContractType = "سرمایه گذاری"
        };
        public static CreatePropertyContractTypeDTO createPropertyContractTypeDTO_Validation_InValid = new CreatePropertyContractTypeDTO
        {
            ContractType = ""
        };
        public static UpdatePropertyContractTypeDTO updatePropertyContractTypeDTO_Validation_InValid = new UpdatePropertyContractTypeDTO
        {
            Id = 1,
        };
        public static UpdatePropertyContractTypeDTO updatePropertyContractTypeDTO_Valid = new UpdatePropertyContractTypeDTO
        {
            Id = 1,
            ContractType = "Iranda"

        };
        public static UpdatePropertyContractTypeDTO updatePropertyContractTypeDTO_Validation_Notfound_InValid = new UpdatePropertyContractTypeDTO
        {
            Id = 50,
            ContractType = "Iranda"
        };
    }
}
