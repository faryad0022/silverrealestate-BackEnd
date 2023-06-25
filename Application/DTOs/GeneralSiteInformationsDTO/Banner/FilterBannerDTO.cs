using Application.DTOs.Paging;
using System.Collections.Generic;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner
{
    public class FilterBannerDTO : BasePaging
    {
        public List<BannerDTO> BannerDTOs { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
    }
}
