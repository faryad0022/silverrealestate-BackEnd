namespace Domain.Entities.GeneralSiteInformation
{
    public class SpectacularLocationImages : BaseEntity
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public long SpectacularlocationId { get; set; }
        public Spectacularlocation Spectacularlocation { get; set; }

    }
}
