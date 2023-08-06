using Application.Const.Response;
using Application.DTOs.Blog.BlogGroup;
using Application.features.Blog.Request.Commands.BlogGroupCommands;
using Application.features.Blog.Request.Queries.BlogGroup;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    [Authorize]

    public class BlogGroupController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public BlogGroupController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.BlogGroup_GetAll, Name = "GetBlogGroupListAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetBlogGroupListAsync()
            => await _mediator.Send(new GetBlogGroupListRequest());

        [HttpGet(ApiRouteV1.BlogGroup_Get, Name = "GetBlogGroupAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetBlogGroupAsync([FromQuery] long id)
            => await _mediator.Send(new GetBlogGroupRequest { blogGroupId = id });


        [HttpPost(ApiRouteV1.BlogGroup_Add, Name = "AddBlogGroupAsync")]
        public async Task<ActionResult<ResponseResultDTO>> AddBlogGroupAsync([FromBody] CreateBlogGroupDTO blogGroupDTO)
            => await _mediator.Send(new CreateBlogGroupRequestCommand { createBlogGroupDTO = blogGroupDTO });

        [HttpPut(ApiRouteV1.BlogGroup_Update, Name = "UpdateBlogGroupAsync")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateBlogGroupAsync([FromBody] UpdateBlogGroupDTO updateBlogGroupDTO )
            => await _mediator.Send(new UpdateBlogGroupRequest { updateBlogGroupDTO = updateBlogGroupDTO });
    }
}
