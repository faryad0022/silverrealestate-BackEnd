namespace Application.DTOs.GeneralSiteInformationsDTO.TeamMembers
{
    public class CreateTeamMmeberDTO : ITeamMemberDTO
    {
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string MemberPosition { get; set; }
        public string MemberPicture { get; set; }
    }
}
