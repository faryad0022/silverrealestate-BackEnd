using Application.DTOs.Paging;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace Application.Filters
{
    public class FilterBanner : BasePaging
    {
        public List<Banner> Banners { get; set; }
        public string Link { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
        public FilterBanner SetPaging(BasePaging paging)
        {
            this.PageId = paging.PageId;
            this.SkipEntity = paging.SkipEntity;
            this.TakeEntity = paging.TakeEntity;
            this.ActivePage = paging.ActivePage;
            this.EndPage = paging.EndPage;
            this.StartPage = paging.StartPage;
            this.PageCount = paging.PageCount;
            return this;
        }
        public FilterBanner SetBanners(List<Banner> banners)
        {
            this.Banners = banners;
            return this;
        }
    }
}
