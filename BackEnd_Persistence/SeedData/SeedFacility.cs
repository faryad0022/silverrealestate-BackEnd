using Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedFacility : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(
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
                );
        }
    }
}
