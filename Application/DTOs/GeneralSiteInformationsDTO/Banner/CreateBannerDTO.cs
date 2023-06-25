using System;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner
{
    public class CreateBannerDTO : IBannerDTO
    {
        public string BannerImage { get; set; }
        public string Link { get; set; }

    }
}
