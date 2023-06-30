using Application.Const.Response;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentWithDetails : IRequest<ResponseResultDTO>
    {
        public long blogContentId { get; set; }
    }
}
