using Application.DTOs.Paging;
using System.Collections.Generic;

namespace Application.DTOs.Blog.BlogContent
{
    public class FilterBlogContentDTO : BasePaging
    {
        public List<BlogContentDTO> BlogContentList { get; set; }
        public string BlogGroupName { get; set; }
        public string Title { get; set; }
        public bool IsDelete { get; set; }
        public bool IsSelected { get; set; }
        public long ViewCount { get; set; }
        public long BlogGroupId { get; set; }
    }
}
