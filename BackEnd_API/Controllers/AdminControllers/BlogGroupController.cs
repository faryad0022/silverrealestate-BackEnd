﻿using Application.DTOs.Blog.BlogGroup;
using Application.features.Blog.Handler.Queries.BlogGroup;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using Application.features.Blog.Request.Queries.BlogGroup;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class BlogGroupController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public BlogGroupController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("get-blog-group-list")]
        public async Task<ActionResult<ReturnData<BlogGroupDTO>>> GetBlogGroupListAsync()
            => await _mediator.Send(new GetBlogGroupListRequest());

        [HttpGet("get-blog-group")]
        public async Task<ActionResult<ReturnData<BlogGroupDTO>>> GetBlogGroupAsync([FromQuery] long id)
            => await _mediator.Send(new GetBlogGroupRequest { blogGroupId = id });


        [HttpPost("add-blog-group")]
        public async Task<ActionResult<ReturnData<CreateBlogGroupDTO>>> AddBlogGroupAsync([FromBody] CreateBlogGroupDTO blogGroupDTO)
            => await _mediator.Send(new CreateBlogGroupRequestCommand { createBlogGroupDTO = blogGroupDTO });
    }
}