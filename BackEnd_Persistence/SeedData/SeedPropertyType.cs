using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedPropertyType : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.HasData(
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
                );
        }
    }
}
