using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.General
{
    public class SeedLogo : IEntityTypeConfiguration<Logo>
    {
        public void Configure(EntityTypeBuilder<Logo> builder)
        {
            builder.HasData(
                new Logo
                {
                    Id = 1,
                    Title = "Silver Net Real Estate",
                    ImageName = "silver.jpg",
                    Description = "The Best real estate in cyprus",
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true
                },
                new Logo
                {
                    Id = 2,
                    Title = "Silver Net Real Estate",
                    ImageName = "silver-net.jpg",
                    Description = "The Best real estate in cyprus",
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = false
                }
                );
        }
    }
}
