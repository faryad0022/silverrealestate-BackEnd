﻿using Application.DTOs.Blog.BlogContent;
using Application.Reaspose;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentWithDetailsListRequest : IRequest<ReturnData<BlogContentDTO>>
    {
    }
}
