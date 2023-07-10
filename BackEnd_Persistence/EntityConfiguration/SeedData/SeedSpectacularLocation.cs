using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData
{
    public class SeedSpectacularLocation : IEntityTypeConfiguration<Spectacularlocation>
    {
        public void Configure(EntityTypeBuilder<Spectacularlocation> builder)
        {
            builder.HasData(
                new Spectacularlocation()
                {
                    Id = 1,
                    IsSelected = true,
                    Name = "Ghost City",
                    CreateDate = DateTime.Now
                },
                new Spectacularlocation()
                {
                    Id = 2,
                    IsSelected = true,
                    Name = "Wall City",
                    CreateDate = DateTime.Now
                },
                new Spectacularlocation()
                {
                    Id = 3,
                    IsSelected = false,
                    Name = "Long Beach",
                    CreateDate = DateTime.Now
                },
                new Spectacularlocation()
                {
                    Id = 4,
                    IsSelected = false,
                    Name = "Casino",
                    CreateDate = DateTime.Now
                }
                );
        }
    }
}
