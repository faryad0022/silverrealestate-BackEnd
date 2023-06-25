using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.Paging;
using System.Collections.Generic;

namespace Application.DTOs.Filters
{
    public class FilterBannerDTO : BasePaging
    {
        public List<BannerDTO> BannerDTOs { get; set; }
        public string Link { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
    }
}
