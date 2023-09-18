using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Blog.BlogGroup;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.DTOs.GeneralSiteInformationsDTO.Social;
using Application.DTOs.Project.PropertDTOs;
using Application.DTOs.Project.PropertyType;
using System.Collections.Generic;

namespace Application.DTOs.Site
{
    public class HomeDTO
    {
        public List<BannerDTO> BannerDTOs { get; set; }
        public List<BlogContentDTO> LatestBlogContent { get; set; }
        public List<PropertyDTO> LatestProperty { get; set; }
        //public List<SocialDTO> SocialList { get; set; }
        //public List<AddressDTO> AddressList { get; set; }
        //public List<PropertyTypeDTO> PropertyTypeList { get; set; }
        //public List<BlogGroupDTO> BlogGroupList { get; set; }
    }
}
