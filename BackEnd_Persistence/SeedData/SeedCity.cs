using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedCity : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
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
                );
        }
    }
}
