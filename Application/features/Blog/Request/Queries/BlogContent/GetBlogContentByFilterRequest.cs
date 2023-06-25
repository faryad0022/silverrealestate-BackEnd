using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;


namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentByFilterRequest : IRequest<ReturnData<FilterBlogContentDTO>>
    {
        public FilterBlogContentDTO filter { get; set; }
    }
}
