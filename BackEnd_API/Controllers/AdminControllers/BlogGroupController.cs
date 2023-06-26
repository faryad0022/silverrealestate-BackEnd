using Application.Const.Response;
using Application.DTOs.Blog.BlogGroup;
using Application.features.Blog.Handler.Queries.BlogGroup;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using Application.features.Blog.Request.Queries.BlogGroup;
using BackEnd_API.Const;
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
        [HttpGet(ApiRouteV1.BlogGroup_GetAll,Name = "GetBlogGroupListAsync")]
        public async Task<ActionResult<ResponseResult>> GetBlogGroupListAsync()
            => await _mediator.Send(new GetBlogGroupListRequest());

        [HttpGet(ApiRouteV1.BlogGroup_Get, Name = "GetBlogGroupAsync")]
        public async Task<ActionResult<ResponseResult>> GetBlogGroupAsync([FromQuery] long id)
            => await _mediator.Send(new GetBlogGroupRequest { blogGroupId = id });


        [HttpPost(ApiRouteV1.BlogGroup_Add, Name = "AddBlogGroupAsync")]
        public async Task<ActionResult<ResponseResult>> AddBlogGroupAsync([FromBody] CreateBlogGroupDTO blogGroupDTO)
            => await _mediator.Send(new CreateBlogGroupRequestCommand { createBlogGroupDTO = blogGroupDTO });
    }
}
