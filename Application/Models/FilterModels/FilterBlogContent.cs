using Application.DTOs.Paging;
using Domain.Entities.Blog;
using System.Collections.Generic;

namespace Application.Models.FilterModels
{
    public class FilterBlogContent : BasePaging
    {
        public List<BlogContent> BlogContentList { get; set; }
        public string BlogGroupName { get; set; }
        public string Title { get; set; }
        public bool IsSelected { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public long ViewCount { get; set; }
        public long BlogGroupId { get; set; }
        public FilterBlogContent SetPaging(BasePaging paging)
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
        public FilterBlogContent SetBlogContents(List<BlogContent> blogContents)
        {
            BlogContentList = blogContents;
            return this;
        }
    }
}
