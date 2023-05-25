using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMemberSocials
{
    public class TeamMemberSocialDTO : BaseEntityDTO, ITeamMemberSocialDTO
    {

        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public long TeamMemberId { get; set; }
        public string TeamMemberName { get; set; }
        public string TeamMemberCellPhone { get; set; }
        public string TeamMemberPosition { get; set; }
        public string TeamMemberPicture { get; set; }
    }
}
