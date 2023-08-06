using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.features.Projects.CityFeatures.Request.Commands;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    [Authorize]

    public class BlogContentController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public BlogContentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.BlogContent_Get_Filter, Name = "GetBlogContentFilter")]
        public async Task<ActionResult<ResponseResultDTO>> GetByFilter([FromQuery] FilterBlogContentDTO filter)
            => await _mediator.Send(new GetBlogContentByFilterRequest { filter = filter });


        [HttpGet(ApiRouteV1.BlogContent_Get_WithDetails, Name = "GetWithDetails")]
        public async Task<ActionResult<ResponseResultDTO>> GetWithDetails([FromQuery] long id)
            => await _mediator.Send(new GetBlogContentWithDetails { blogContentId = id });


        [HttpGet(ApiRouteV1.BlogContent_GetAll_WithDetails, Name = "GetWithDetailsList")]
        public async Task<ActionResult<ResponseResultDTO>> GetWithDetailsList()
            => await _mediator.Send(new GetBlogContentWithDetailsListRequest());

        [HttpPost(ApiRouteV1.BlogContent_Add, Name = "AddBlogContentAsync")]
        public async Task<ActionResult<ResponseResultDTO>> AddBlogContentAsync([FromBody] CreateBlogContentDTO createBlogContentDTO)
            => await _mediator.Send(new CreateBlogContentRequest() { createBlogContentDTO = createBlogContentDTO });

        [HttpPut(ApiRouteV1.BlogContent_Delete, Name = "DeleteBlogContent")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteCity([FromBody] long id)
            => await _mediator.Send(new DeleteBlogContentRequest() { Id = id });

        [HttpPut(ApiRouteV1.BlogContent_Update, Name = "UpdateBlogContentAsync")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateBlogContentAsync([FromBody] UpdateBlogContentDTO updateBlogContentDTO)
            => await _mediator.Send(new UpdateBlogcontentRequest() { updateBlogContentDTO = updateBlogContentDTO });


        [HttpPut(ApiRouteV1.BlogContent_ChangeStatus, Name = "ChangeBlogContentStatusAsync")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeBlogContentIsSelectedAsync([FromBody] long id)
            => await _mediator.Send(new ChangeStatusBlogContentRequest() { Id = id});
    }
}
