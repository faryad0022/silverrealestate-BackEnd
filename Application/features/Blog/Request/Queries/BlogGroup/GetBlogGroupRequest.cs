﻿using Application.Const.Response;
using Application.DTOs.Blog.BlogGroup;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogGroup
{
    public class GetBlogGroupRequest : IRequest<ResponseResultDTO>
    {
        public long blogGroupId { get; set; }
    }
}
