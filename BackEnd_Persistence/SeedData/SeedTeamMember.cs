using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.SeedData
{
    public class SeedTeamMember : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasData(
                new TeamMember
                {
                    Id = 1,
                    CellPhone = "09123071411",
                    MemberPicture = "faryad.jpg",
                    MemberPosition = "CEO",
                    Name = "Faryad",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new TeamMember
                {
                    Id = 2,
                    CellPhone = "09352499091",
                    MemberPicture = "farzad.jpg",
                    MemberPosition = "CEO",
                    Name = "Farzad",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new TeamMember
                {
                    Id = 3,
                    CellPhone = "09122895170",
                    MemberPicture = "mojgan.jpg",
                    MemberPosition = "Sell Manager",
                    Name = "Mojgan",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                }
                );
        }
    }
}
