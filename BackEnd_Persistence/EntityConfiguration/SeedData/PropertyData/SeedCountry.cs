using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.PropertyData
{
    public class SeedCountry : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
                );
        }
    }
}
