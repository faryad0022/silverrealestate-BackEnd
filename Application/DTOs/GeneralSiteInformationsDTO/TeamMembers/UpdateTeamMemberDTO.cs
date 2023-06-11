using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers
{
    public class UpdateTeamMemberDTO : BaseEntityDTO, ITeamMemberDTO
    {
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string MemberPosition { get; set; }
        public string MemberPicture { get; set; }
        public string Email { get; set; }
    }
}
