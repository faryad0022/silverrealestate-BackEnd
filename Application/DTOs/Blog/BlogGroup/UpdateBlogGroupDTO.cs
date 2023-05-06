using Application.DTOs.Blog.BlogGroup.Common;
using Application.DTOs.Common;

namespace Application.DTOs.Blog.BlogGroup
{
    public class UpdateBlogGroupDTO:BaseEntityDTO,IBlogGroupDTO
    {
        public string Name { get; set; }

    }
}
