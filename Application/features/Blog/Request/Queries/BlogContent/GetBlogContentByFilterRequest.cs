﻿using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using MediatR;


namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetBlogContentByFilterRequest : IRequest<ResponseResultDTO>
    {
        public FilterBlogContentDTO filter { get; set; }
    }
}
