using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyGalleries
{
    public class UpdatePropertyGalleryDTO : BaseEntityDTO, IPropertyGalleryDTO
    {
        public string ImageName { get; set; }
        public long PropertyId { get; set; }
    }
}
