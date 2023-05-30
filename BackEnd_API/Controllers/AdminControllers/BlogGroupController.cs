using Application.DTOs.Blog.BlogGroup;
using Application.features.Blog.Handler.Queries.BlogGroup;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using Application.features.Blog.Request.Queries.BlogGroup;
using Application.Reaspose;
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
        [HttpGet(ApiRouteV1.BlogGroup_GetAll)]
        public async Task<ActionResult<ReturnData<BlogGroupDTO>>> GetBlogGroupListAsync()
            => await _mediator.Send(new GetBlogGroupListRequest());

        [HttpGet(ApiRouteV1.BlogGroup_Get)]
        public async Task<ActionResult<ReturnData<BlogGroupDTO>>> GetBlogGroupAsync([FromQuery] long id)
            => await _mediator.Send(new GetBlogGroupRequest { blogGroupId = id });


        [HttpPost(ApiRouteV1.BlogGroup_Add)]
        public async Task<ActionResult<ReturnData<CreateBlogGroupDTO>>> AddBlogGroupAsync([FromBody] CreateBlogGroupDTO blogGroupDTO)
            => await _mediator.Send(new CreateBlogGroupRequestCommand { createBlogGroupDTO = blogGroupDTO });
    }
}
