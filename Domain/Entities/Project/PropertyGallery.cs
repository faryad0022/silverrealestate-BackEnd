namespace Domain.Entities.Project
{
    public class PropertyGallery : BaseEntity
    {
        public string ImageName { get; set; }
        public long PropertyId { get; set; }

        public Property ProPerty { get; set; }
    }
}
