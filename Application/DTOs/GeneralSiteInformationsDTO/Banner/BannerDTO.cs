using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner
{
    public class BannerDTO : BaseEntityDTO, IBannerDTO
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string ShortText { get; set; }
        public string RealEstateLogo { get; set; }
        public string PhoneLogo { get; set; }
    }
}
