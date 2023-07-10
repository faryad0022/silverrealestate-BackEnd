using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.PropertyData
{
    public class SeedPropertyContractType : IEntityTypeConfiguration<PropertyContractType>
    {
        public void Configure(EntityTypeBuilder<PropertyContractType> builder)
        {
            builder.HasData(
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
                );
        }
    }
}
