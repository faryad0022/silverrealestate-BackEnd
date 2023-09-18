using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyVideos
{
    public class UpdatePropertyVideoDTO : BaseEntityDTO, IPropertyVideoDTO
    {
        public string VideoLink { get; set; }
        public long PropertyId { get; set; }
    }
}
