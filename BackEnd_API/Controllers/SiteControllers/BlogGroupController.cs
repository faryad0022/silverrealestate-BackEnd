using Application.Const.Response;
using Application.features.Blog.Request.Queries.BlogGroup;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{

    public class BlogGroupController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public BlogGroupController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.BlogGroup_GetAll, Name = "SiteGetBlogGroupListAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetBlogGroupListAsync()
            => await _mediator.Send(new GetBlogGroupListRequest());

        [HttpGet(ApiRouteV1.BlogGroup_Get, Name = "SiteGetBlogGroupAsync")]
        public async Task<ActionResult<ResponseResultDTO>> GetBlogGroupAsync([FromQuery] long id)
            => await _mediator.Send(new GetBlogGroupRequest { blogGroupId = id });

    }
}
