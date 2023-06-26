using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentWithDetails : IRequest<ResponseResult>
    {
        public long blogContentId { get; set; }
    }
}
