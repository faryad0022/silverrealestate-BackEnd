using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyVideos
{
    public class PropertyVideoDTO : BaseEntityDTO
    {
        public string VideoLink { get; set; }
        public long PropertyId { get; set; }

    }
}
