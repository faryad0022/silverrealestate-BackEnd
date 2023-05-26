using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using Domain.Entities.GeneralSiteInformation;
using System;
using System.Collections.Generic;

namespace BackEnd_UnitTest.Mocks.Models
{
    public static class TeamMemberSocialModelGenerator
    {
        public static List<TeamMemberSocial> teamMemberSocialsList = new()
        {
            new TeamMemberSocial
            {
                Id=1,
                TeamMemberId=1,
                Icon="fa fa-instagram",
                Link = "faryad/Instagram.com",
                Name="Instagram",
                IsSelected=true,
                IsDelete=false,
                CreateDate=DateTime.Now,
            },
            new TeamMemberSocial
            {
                Id=2,
                TeamMemberId=1,
                Icon="fa fa-facebook",
                Link = "faryad/FaceBook.com",
                Name="Facebook",
                IsSelected=true,
                IsDelete=false,
                CreateDate=DateTime.Now
            },
            new TeamMemberSocial
            {
                Id=3,
                TeamMemberId=1,
                Icon="fa fa-tiktok",
                Link = "faryad/TikTok.com",
                Name="TikTok",
                IsSelected=false,
                IsDelete=false,
                CreateDate=DateTime.Now
            },
        };

        public static CreateTeamMemberSocialDTO CreateTeamMemberSocialDTO_Valid = new()
        {
            Icon = "fa fa-linkdin",
            Name = "LinkDin",
            Link="faryad/Linkdin",
            TeamMemberId = 1
        };
        public static CreateTeamMemberSocialDTO CreateTeamMemberSocialDTO_ValidationError_InValid = new()
        {
            Icon = "",
            Name = "LinkDin",
            TeamMemberId = 1
        };

        public static UpdateTeamMemberSocialDTO UpdateTeamMemberSocialDTO_Valid = new()
        {
            Id = 1,
            TeamMemberId = 1,
            Icon = "fab fa-instagram",
            Link = "faryad/Instagram.com",
            Name = "Instagram",
        };
        public static UpdateTeamMemberSocialDTO UpdateTeamMemberSocialDTO_NotFound_InValid = new()
        {
            Id = 11,
            TeamMemberId = 1,
            Icon = "fab fa-instagram",
            Link = "faryad/Instagram.com",
            Name = "Instagram",
        };
        public static UpdateTeamMemberSocialDTO UpdateTeamMemberSocialDTO_ValidationError_InValid = new()
        {
            Id = 1,
            TeamMemberId = 1,
            Icon = "fab fa-instagram",
            Link = "faryad/Instagram.com",
            Name = "",
        };
        public static UpdateTeamMemberSocialDTO UpdateTeamMemberSocialDTO_ValidationError_MustSelectParent_InValid = new()
        {
            Id = 1,
            Icon = "fab fa-instagram",
            Link = "faryad/Instagram.com",
            Name = "Instagram",
        };
    }
}
