namespace Domain.Entities.GeneralSiteInformation
{
    public class Banner : BaseEntity
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string ShortText { get; set; }
        public string RealEstateLogo { get; set; }
        public string PhoneLogo { get; set; }
    }
}
