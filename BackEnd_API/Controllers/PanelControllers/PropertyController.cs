using Application.Const.Response;
using Application.DTOs.Project.PropertDTOs;
using Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    public class PropertyController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public PropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.Property_GetAll, Name = "GetAllProperties")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllProperties()
            => await _mediator.Send(new GetPropertyListWithDetailsRequest());


        [HttpGet(ApiRouteV1.Property_GetFilter, Name = "GetFilterProperties")]
        public async Task<ActionResult<ResponseResultDTO>> GetFilterProperties([FromQuery] FilterPropertyDTO filterDTO)
            => await _mediator.Send(new GetFilterPropertyRequest() { filterDTO = filterDTO });

        [HttpGet(ApiRouteV1.Property_Get, Name = "GetProperty")]
        public async Task<ActionResult<ResponseResultDTO>> GetProperty([FromBody] long Id)
            => await _mediator.Send(new GetPropertyWithDetailsRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Property_Add, Name = "AddProperty")]
        public async Task<ActionResult<ResponseResultDTO>> AddProperty([FromBody] CreatePropertyDTO createPropertyDTO)
            => await _mediator.Send(new CreatePropertyRequest() { createPropertyDTO = createPropertyDTO });


        [HttpPut(ApiRouteV1.Property_Update, Name = "UpdateProperty")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateProperty([FromBody] UpdatePropertyDTO updatePropertyDTO)
            => await _mediator.Send(new UpdatePropertyRequest() { updatePropertyDTO = updatePropertyDTO });


        [HttpPut(ApiRouteV1.Property_Delete, Name = "DeleteProperty")]
        public async Task<ActionResult<ResponseResultDTO>> DeleteProperty([FromBody] long id)
            => await _mediator.Send(new DeletePropertyRequest() { Id = id });

        [HttpPut(ApiRouteV1.Property_ChangeStatus, Name = "ChangePropertyStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangePropertyStatus([FromBody] long id)
            => await _mediator.Send(new ChangePropertyStatusRequest() { Id = id });
    }
}
