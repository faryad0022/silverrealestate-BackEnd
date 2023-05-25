using Application.DTOs.Common;

namespace Application.DTOs.Blog.BlogContent
{
    public class BlogContentListDTO : BaseEntityDTO
    {
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Review { get; set; }
        public long ViewCount { get; set; }
        public long BlogGroupId { get; set; }
        public string BlogGroupName { get; set; }
    }
}
