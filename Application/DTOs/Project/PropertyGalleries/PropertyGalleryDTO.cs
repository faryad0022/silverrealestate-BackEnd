using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyGalleries
{
    public class PropertyGalleryDTO : BaseEntityDTO
    {
        public string ImageName { get; set; }
        public long PropertyId { get; set; }

    }
}
