using Application.DTOs.Common;
using System;

namespace Application.DTOs.Blog.BlogContent
{
    public class BlogContentDTO : BaseEntityDTO
    {
        public string BlogGroupName { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string ImageName { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; } = false;
        public bool IsSelected { get; set; } = false;
        public long ViewCount { get; set; } = 0;
        public long BlogGroupId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
