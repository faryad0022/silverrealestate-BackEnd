using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData
{
    public class SeedSocial : IEntityTypeConfiguration<Social>
    {
        public void Configure(EntityTypeBuilder<Social> builder)
        {
            builder.HasData(
                new Social
                {
                    Id = 1,
                    Icon = "fa fa-instagram",
                    Name = "Instagram",
                    Link = "instagram.com",
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true
                },
                new Social
                {
                    Id = 2,
                    Icon = "fa fa-facebok",
                    Name = "Facebook",
                    Link = "facebook.com",
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true
                }
                );
        }
    }
}
