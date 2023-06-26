using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.features.Blog.Request.Queries.BlogContent;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class BlogContentController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public BlogContentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.BlogContent_Get_Filter,Name = "GetBlogContentFilter")]
        public async Task<ActionResult<ResponseResult>> GetByFilter([FromQuery] FilterBlogContentDTO filter)
            => await _mediator.Send(new GetBlogContentByFilterRequest { filter = filter });
 

        [HttpGet(ApiRouteV1.BlogContent_Get_WithDetails, Name = "GetWithDetails")]
        public async Task<ActionResult<ResponseResult>> GetWithDetails([FromQuery] long id)
            => await _mediator.Send(new GetBlogContentWithDetails { blogContentId = id });


        [HttpGet(ApiRouteV1.BlogContent_GetAll_WithDetails, Name = "GetWithDetailsList")]
        public async Task<ActionResult<ResponseResult>> GetWithDetailsList()
            => await _mediator.Send(new GetBlogContentWithDetailsListRequest());

        [HttpPost(ApiRouteV1.BlogContent_Add, Name = "AddBlogContentAsync")]
        public async Task<ActionResult<ResponseResult>> AddBlogContentAsync([FromBody] CreateBlogContentDTO createBlogContentDTO)
            => await _mediator.Send(new CreateBlogContentRequest() { createBlogContentDTO = createBlogContentDTO });



        [HttpPut(ApiRouteV1.BlogContent_Update,Name = "UpdateBlogContentAsync")]
        public async Task<ActionResult<ResponseResult>> UpdateBlogContentAsync([FromBody] UpdateBlogContentDTO updateBlogContentDTO)
            => await _mediator.Send(new UpdateBlogcontentRequest() { updateBlogContentDTO = updateBlogContentDTO });


        [HttpPut(ApiRouteV1.BlogContent_ChangeStatus,Name = "ChangeBlogContentIsSelectedAsync")]
        public async Task<ActionResult<ResponseResult>> ChangeBlogContentIsSelectedAsync([FromBody] ChangeBlogContentIsSelectedDTO changeBlogContentIsSelected, [FromQuery] long Id)
            => await _mediator.Send(new UpdateBlogcontentRequest()
            {
                Id = Id,
                changeBlogContentIsSelected = changeBlogContentIsSelected
            });
    }
}
