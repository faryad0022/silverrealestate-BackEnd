namespace Domain.Entities.GeneralSiteInformation
{
    public class Banner : BaseEntity
    {
        public string BannerImage { get; set; }
        public string Link { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
    }
}
