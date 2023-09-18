using Application.Const.Response;
using Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class PropertyVideoController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public PropertyVideoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyVideo_GetAll, Name = "SiteGetAllPropertyVideos")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyVideos([FromQuery] long propertyId)
            => await _mediator.Send(new GetPropertyVideoListRequest() { PropertyId = propertyId });


        [HttpGet(ApiRouteV1.PropertyVideo_Get, Name = "SiteGetPropertyVideo")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyVideo([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyVideoRequest() { Id = Id });

    }
}
