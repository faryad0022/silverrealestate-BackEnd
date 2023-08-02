using Application.Const.Response;
using Application.DTOs.Blog.BlogContent;
using Application.features.Blog.Request.Commands.BlogContentCommands;
using Application.features.Blog.Request.Queries.BlogContent;
using Application.features.Projects.CityFeatures.Request.Commands;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{

    public class BlogContentController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public BlogContentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.BlogContent_Get_Filter, Name = "SiteGetBlogContentFilter")]
        public async Task<ActionResult<ResponseResultDTO>> GetByFilter([FromQuery] FilterBlogContentDTO filter)
            => await _mediator.Send(new GetBlogContentByFilterRequest { filter = filter });


        [HttpGet(ApiRouteV1.BlogContent_Get_WithDetails, Name = "SiteGetWithDetails")]
        public async Task<ActionResult<ResponseResultDTO>> GetWithDetails([FromQuery] long id)
            => await _mediator.Send(new GetBlogContentWithDetails { blogContentId = id });


        [HttpGet(ApiRouteV1.BlogContent_GetAll_WithDetails, Name = "SiteGetWithDetailsList")]
        public async Task<ActionResult<ResponseResultDTO>> GetWithDetailsList()
            => await _mediator.Send(new GetBlogContentWithDetailsListRequest());


    }
}
