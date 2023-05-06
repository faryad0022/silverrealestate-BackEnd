using Application.DTOs.Blog.BlogGroup.Common;

namespace Application.DTOs.Blog.BlogGroup
{
    public class CreateBlogGroupDTO : IBlogGroupDTO
    {
        public string Name { get; set; }
    }
}
