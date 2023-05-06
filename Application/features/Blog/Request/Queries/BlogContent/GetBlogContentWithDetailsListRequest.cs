using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;
using System.Collections.Generic;

namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentWithDetailsListRequest : IRequest<ReturnData<BlogContentDTO>>
    {
    }
}
