using Application.DTOs.Blog.BlogGroup;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogGroup
{
    public class GetBlogGroupListRequest : IRequest<ReturnData<BlogGroupDTO>>
    {
    }
}
