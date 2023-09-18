using Application.Const.Response;
using Application.DTOs.Project.PropertyVideos;
using Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    public class PropertyVideoController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public PropertyVideoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyVideo_GetAll, Name = "GetAllPropertyVideos")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyVideos([FromQuery] long propertyId)
            => await _mediator.Send(new GetPropertyVideoListRequest() { PropertyId = propertyId });


        [HttpGet(ApiRouteV1.PropertyVideo_Get, Name = "GetPropertyVideo")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyVideo([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyVideoRequest() { Id = Id });

        [HttpPost(ApiRouteV1.PropertyVideo_Add, Name = "AddPropertyVideo")]
        public async Task<ActionResult<ResponseResultDTO>> AddPropertyVideo([FromBody] CreatePropertyVideoDTO createPropertyVideoDTO)
            => await _mediator.Send(new CreatePropertyVideoRequest() { createPropertyVideoDTO = createPropertyVideoDTO });

        [HttpPut(ApiRouteV1.PropertyVideo_Update, Name = "UpdatePropertyVideo")]
        public async Task<ActionResult<ResponseResultDTO>> UpdatePropertyVideo([FromBody] UpdatePropertyVideoDTO updatePropertyVideoDTO)
            => await _mediator.Send(new UpdatePropertyVideoRequest() { updatePropertyVideoDTO = updatePropertyVideoDTO });


        [HttpPut(ApiRouteV1.PropertyVideo_Delete, Name = "DeletePropertyVideo")]
        public async Task<ActionResult<ResponseResultDTO>> DeletePropertyVideo([FromBody] long id)
            => await _mediator.Send(new DeletePropertyVideoRequest() { Id = id });
    }
}
