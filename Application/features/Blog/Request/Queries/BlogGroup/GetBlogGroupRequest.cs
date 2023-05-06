using Application.DTOs.Blog.BlogGroup;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogGroup
{
    public class GetBlogGroupRequest : IRequest<ReturnData<BlogGroupDTO>>
    {
        public long blogGroupId { get; set; }
    }
}
