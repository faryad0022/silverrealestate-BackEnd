using Application.DTOs.GeneralSiteInformationsDTO.TeamMembers;
using Domain.Entities.GeneralSiteInformation;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models.TeamMembers
{
    public static class TeamMemberModelGenerator
    {
        public static List<TeamMember> TeamMemberList = new()
        {
                new TeamMember
                {
                    Id = 1,
                    CellPhone = "09123071411",
                    MemberPicture = "faryad.jpg",
                    MemberPosition = "CEO",
                    Name = "Faryad",
                    Email="mahancomputer49@gmail.com",
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
                    Email="mahancomputer49@gmail.com",
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
                    Email="mahancomputer49@gmail.com",
                    CreateDate = DateTime.Now,
                    IsSelected = true,
                    IsDelete = false
                },
                new TeamMember
                {
                    Id = 4,
                    CellPhone = "00905338355243",
                    MemberPicture = "payam.jpg",
                    MemberPosition = "Sell Manager",
                    Name = "Payam",
                    Email="mahancomputer49@gmail.com",
                    CreateDate = DateTime.Now,
                    IsSelected = false,
                    IsDelete = false
                }
        };


        public static CreateTeamMmeberDTO CreateTeamMmeberDTO_Valid = new()
        {
            CellPhone = "09125757063",
            MemberPicture = "asghar.jpg",
            MemberPosition = "CEO",
            Name = "Asghar",
            Email = "mahancomputer49@gmail.com",
        };
        public static CreateTeamMmeberDTO CreateTeamMmeberDTO_ValidationError_InValid = new()
        {
            CellPhone = "09125757063",
            MemberPicture = "asghar.jpg",
            MemberPosition = "CEO",
            Name = "",
        };

        public static UpdateTeamMemberDTO UpdateTeamMemberDTO_Valid = new()
        {
            Id = 4,
            CellPhone = "00905338355243",
            MemberPicture = "payam.jpg",
            MemberPosition = "Sell Manager",
            Name = "Payam Abolhassani",
            Email = "mahancomputer49@gmail.com",
        };
        public static UpdateTeamMemberDTO UpdateTeamMemberDTO_NotFound_InValid = new()
        {
            Id = 40,
            CellPhone = "00905338355243",
            MemberPicture = "payam.jpg",
            MemberPosition = "Sell Manager",
            Name = "Payam Abolhassani",
        };
        public static UpdateTeamMemberDTO UpdateTeamMemberDTO_ValidationError_InValid = new()
        {
            Id = 4,
            CellPhone = "00905338355243",
            MemberPicture = "payam.jpg",
            MemberPosition = "",
            Name = "Payam Abolhassani",
        };


    }
}
