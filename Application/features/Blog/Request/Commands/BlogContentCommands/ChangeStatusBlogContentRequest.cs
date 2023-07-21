﻿using Application.Const.Response;
using MediatR;

namespace Application.features.Blog.Request.Commands.BlogContentCommands
{
    public class ChangeStatusBlogContentRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
