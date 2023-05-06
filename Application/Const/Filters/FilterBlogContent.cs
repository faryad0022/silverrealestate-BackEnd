using Domain.Entities.Blog;
using System.Collections.Generic;

namespace Application.Const.Filters
{
    public class FilterBlogContent
    {
        public List<BlogContent> BlogContentList { get; set; }
        public string BlogGroupName { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
        public bool Status { get; set; }
        public bool IsSelected { get; set; }
        public long ViewCount { get; set; }
        public long BlogGroupId { get; set; }
    }
}
