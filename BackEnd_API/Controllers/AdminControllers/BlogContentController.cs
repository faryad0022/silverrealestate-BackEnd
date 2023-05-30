using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Filters;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Reaspose;
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

        [HttpGet(ApiRouteV1.BlogContent_Get_Filter,Name = "GetByFilter")]
        public async Task<ActionResult<ReturnData<FilterBlogContentDTO>>> GetByFilter([FromQuery] FilterBlogContentDTO filter)
        {
            return await _mediator.Send(new GetBlogContentByFilterRequest { filter = filter });
        }

        [HttpGet(ApiRouteV1.BlogContent_Get_WithDetails, Name = "GetWithDetails")]
        public async Task<ActionResult<ReturnData<BlogContentDTO>>> GetWithDetails([FromQuery] long id)
        {
            return await _mediator.Send(new GetBlogContentWithDetails { blogContentId = id });
        }

        [HttpGet(ApiRouteV1.BlogContent_GetAll_WithDetails, Name = "GetWithDetailsList")]
        public async Task<ActionResult<ReturnData<BlogContentDTO>>> GetWithDetailsList()
        {
            return await _mediator.Send(new GetBlogContentWithDetailsListRequest());
        }

        [HttpPost(ApiRouteV1.BlogContent_Add, Name = "AddBlogContentAsync")]
        public async Task<ActionResult<ReturnData<CreateBlogContentDTO>>> AddBlogContentAsync([FromBody] CreateBlogContentDTO createBlogContentDTO)
            => await _mediator.Send(new CreateBlogContentRequest() { createBlogContentDTO = createBlogContentDTO });



        [HttpPut(ApiRouteV1.BlogContent_Update,Name = "UpdateBlogContentAsync")]
        public async Task<ActionResult<ReturnData<UpdateBlogContentDTO>>> UpdateBlogContentAsync([FromBody] UpdateBlogContentDTO updateBlogContentDTO)
            => await _mediator.Send(new UpdateBlogcontentRequest() { updateBlogContentDTO = updateBlogContentDTO });


        [HttpPut(ApiRouteV1.BlogContent_ChangeStatus,Name = "ChangeBlogContentIsSelectedAsync")]
        public async Task<ActionResult<ReturnData<UpdateBlogContentDTO>>> ChangeBlogContentIsSelectedAsync([FromBody] ChangeBlogContentIsSelectedDTO changeBlogContentIsSelected, [FromQuery] long Id)
            => await _mediator.Send(new UpdateBlogcontentRequest()
            {
                Id = Id,
                changeBlogContentIsSelected = changeBlogContentIsSelected
            });
    }
}
