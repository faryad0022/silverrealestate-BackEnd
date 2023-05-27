using Application.DTOs.Blog.BlogContent;
using Application.DTOs.Filters;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.Reaspose;
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

        [HttpGet("get-filter-blogcontents")]
        public async Task<ActionResult<ReturnData<FilterBlogContentDTO>>> GetByFilter([FromQuery] FilterBlogContentDTO filter)
        {
            return await _mediator.Send(new GetBlogContentByFilterRequest { filter = filter });
        }

        [HttpGet("get-with-details-blogcontents")]
        public async Task<ActionResult<ReturnData<BlogContentDTO>>> GetWithDetails([FromQuery] long id)
        {
            return await _mediator.Send(new GetBlogContentWithDetails { blogContentId = id });
        }

        [HttpGet("get-with-details-list-blogcontents")]
        public async Task<ActionResult<ReturnData<BlogContentDTO>>> GetWithDetailsList()
        {
            return await _mediator.Send(new GetBlogContentWithDetailsListRequest());
        }

        [HttpPost("add-blog-content")]
        public async Task<ActionResult<ReturnData<CreateBlogContentDTO>>> AddBlogContentAsync([FromBody] CreateBlogContentDTO createBlogContentDTO)
            => await _mediator.Send(new CreateBlogContentRequest() { createBlogContentDTO = createBlogContentDTO });



        [HttpPut("update-blog-content")]
        public async Task<ActionResult<ReturnData<UpdateBlogContentDTO>>> UpdateBlogContentAsync([FromBody] UpdateBlogContentDTO updateBlogContentDTO)
            => await _mediator.Send(new UpdateBlogcontentRequest() { updateBlogContentDTO = updateBlogContentDTO });

        [HttpPut("change-blog-content-status")]
        public async Task<ActionResult<ReturnData<UpdateBlogContentDTO>>> ChangeBlogContentStatusAsync([FromBody] ChangeBlogContentStatusDTO changeBlogContentStatusDTO, [FromQuery] long Id)
            => await _mediator.Send(new UpdateBlogcontentRequest()
            {
                Id = Id,
                changeBlogContentStatusDTO = changeBlogContentStatusDTO
            });

        [HttpPut("change-blog-content-isselected")]
        public async Task<ActionResult<ReturnData<UpdateBlogContentDTO>>> ChangeBlogContentIsSelectedAsync([FromBody] ChangeBlogContentIsSelectedDTO changeBlogContentIsSelected, [FromQuery] long Id)
            => await _mediator.Send(new UpdateBlogcontentRequest()
            {
                Id = Id,
                changeBlogContentIsSelected = changeBlogContentIsSelected
            });
    }
}
