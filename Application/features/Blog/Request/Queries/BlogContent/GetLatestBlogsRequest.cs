﻿using Application.Const.Response;
using MediatR;

namespace Application.features.Blog.Request.Queries.BlogContent
{
    public class GetLatestBlogsRequest : IRequest<ResponseResultDTO>
    {
    }
}
