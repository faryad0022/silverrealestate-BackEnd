using Application.DTOs.Common;

namespace Application.DTOs.Blog.BlogContent
{
    public class BlogContentSelectedDTO : BaseEntityDTO
    {
        public string BlogGroupName { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string ImageName { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
        public bool IsSelected { get; set; }
        public long ViewCount { get; set; } = 0;
        public long BlogGroupId { get; set; }
    }
}
