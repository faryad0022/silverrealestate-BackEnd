using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedTeamMemberSocial : IEntityTypeConfiguration<TeamMemberSocial>
    {
        public void Configure(EntityTypeBuilder<TeamMemberSocial> builder)
        {
            builder.HasData(
            new TeamMemberSocial
            {
                Id = 1,
                TeamMemberId = 1,
                Icon = "fa fa-instagram",
                Link = "faryad/Instagram.com",
                Name = "Instagram",
                IsSelected = true,
                IsDelete = false,
                CreateDate = DateTime.Now
            },
            new TeamMemberSocial
            {
                Id = 2,
                TeamMemberId = 1,
                Icon = "fa fa-facebook",
                Link = "faryad/FaceBook.com",
                Name = "Facebook",
                IsSelected = true,
                IsDelete = false,
                CreateDate = DateTime.Now
            },
            new TeamMemberSocial
            {
                Id = 3,
                TeamMemberId = 1,
                Icon = "fa fa-tiktok",
                Link = "faryad/TikTok.com",
                Name = "TikTok",
                IsSelected = false,
                IsDelete = false,
                CreateDate = DateTime.Now
            }
            );
        }
    }
}
