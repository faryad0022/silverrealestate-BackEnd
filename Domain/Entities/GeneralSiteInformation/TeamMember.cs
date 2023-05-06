using System.Collections.Generic;

namespace Domain.Entities.GeneralSiteInformation
{
    public class TeamMember : BaseEntity
    {
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string MemberPosition { get; set; }
        public string MemberPicture { get; set; }
        public ICollection<TeamMemberSocial> TeamMemberSocials { get; set; }
    }
}
