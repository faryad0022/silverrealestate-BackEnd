using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner
{
    public class BannerDTO : BaseEntityDTO, IBannerDTO
    {
        public string BannerImage { get; set; }
        public string Link { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
        public string Alt { get; set; }
        public string Description { get; set; }
    }
}