using Application.DTOs.Paging;
using System.Collections.Generic;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers
{
    public class FilterTeamMemberDTO : BasePaging
    {
        public List<TeamMemberDTO> TeamMembersDTO { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string MemberPosition { get; set; }
        public string Email { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
    }
}
