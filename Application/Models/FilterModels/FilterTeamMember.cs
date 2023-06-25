using Application.DTOs.Paging;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace Application.Models.FilterModels
{
    public class FilterTeamMember : BasePaging
    {
        public List<TeamMember> TeamMembers { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string MemberPosition { get; set; }
        public string Email { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
        public FilterTeamMember SetPaging(BasePaging paging)
        {
            PageId = paging.PageId;
            SkipEntity = paging.SkipEntity;
            TakeEntity = paging.TakeEntity;
            ActivePage = paging.ActivePage;
            EndPage = paging.EndPage;
            StartPage = paging.StartPage;
            PageCount = paging.PageCount;
            return this;
        }
        public FilterTeamMember SetTeamMembers(List<TeamMember> teamMembers)
        {
            TeamMembers = teamMembers;
            return this;
        }
    }
}
