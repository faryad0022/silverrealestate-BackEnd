using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyVideos
{
    public class PropertyVideoDTO : BaseEntityDTO
    {
        public string YoutubeLink { get; set; }
        public string AparatLink { get; set; }
        public long PropertyId { get; set; }

    }
}
