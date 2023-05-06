using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentWithDetails : IRequest<ReturnData<BlogContentDTO>>
    {
        public long blogContentId { get; set; }
    }
}
