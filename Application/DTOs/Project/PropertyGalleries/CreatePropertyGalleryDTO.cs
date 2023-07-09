namespace Application.DTOs.Project.PropertyGalleries
{
    public class CreatePropertyGalleryDTO : IPropertyGalleryDTO
    {
        public string ImageName { get; set; }
        public long PropertyId { get; set; }
    }
}
