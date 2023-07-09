using Application.DTOs.Common;

namespace Application.DTOs.Project
{
    public class PropertyVideoDTO : BaseEntityDTO
    {
        public string YoutubeLinlk { get; set; }
        public string AparatLinlk { get; set; }

        public long PropertyId { get; set; }

    }
}
