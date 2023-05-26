using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials
{
    public class UpdateTeamMemberSocialDTO :BaseEntityDTO, ITeamMemberSocialDTO
    {
        public long TeamMemberId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
