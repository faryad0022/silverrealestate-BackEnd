namespace Domain.Entities.GeneralSiteInformation
{
    public class TeamMemberSocial : BaseEntity
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public long TeamMemberId { get; set; }
    }
}
