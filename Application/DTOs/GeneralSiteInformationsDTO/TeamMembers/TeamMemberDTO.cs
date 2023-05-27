using Application.DTOs.Common;
using Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials;
using System.Collections.Generic;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers
{
    public class TeamMemberDTO : BaseEntityDTO, ITeamMemberDTO
    {
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string MemberPosition { get; set; }
        public string MemberPicture { get; set; }
        public ICollection<TeamMemberSocialDTO> TeamMemberSocials { get; set; }
    }
}
