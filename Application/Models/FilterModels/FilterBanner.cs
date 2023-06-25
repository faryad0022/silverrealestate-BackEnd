using Application.DTOs.Paging;
using Domain.Entities.GeneralSiteInformation;
using System.Collections.Generic;

namespace Application.Models.FilterModels
{
    public class FilterBanner : BasePaging
    {
        public List<Banner> Banners { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
        public FilterBanner SetPaging(BasePaging paging)
        {
            PageId = paging.PageId;
            SkipEntity = paging.SkipEntity;
            TakeEntity = paging.TakeEntity;
            ActivePage = paging.ActivePage;
            EndPage = paging.EndPage;
            StartPage = paging.StartPage;
            PageCount = paging.PageCount;
            return this;
        }
        public FilterBanner SetBanners(List<Banner> banners)
        {
            Banners = banners;
            return this;
        }
    }
}
