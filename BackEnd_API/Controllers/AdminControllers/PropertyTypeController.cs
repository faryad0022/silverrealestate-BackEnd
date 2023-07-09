using Application.Const.Response;
using Application.DTOs.Project.PropertyType;
using Application.features.Projects.PropertyTypeFeatures.Request.Commands;
using Application.features.Projects.PropertyTypeFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{
    public class PropertyTypeController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public PropertyTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyType_GetAll, Name = "GetAllPropertyTypes")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyTypes()
            => await _mediator.Send(new GetPropertyTypeListRequest());


        [HttpGet(ApiRouteV1.PropertyType_Get, Name = "GetPropertyType")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyType([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyTypeRequest() { Id = Id });

        [HttpPost(ApiRouteV1.PropertyType_Add, Name = "AddPropertyType")]
        public async Task<ActionResult<ResponseResultDTO>> AddPropertyType([FromBody] CreatePropertyTypeDTO createPropertyTypeDTO)
            => await _mediator.Send(new CreatePropertyTypeRequest() { createPropertyTypeDTO = createPropertyTypeDTO });


        [HttpPut(ApiRouteV1.PropertyType_Update, Name = "UpdatePropertyType")]
        public async Task<ActionResult<ResponseResultDTO>> UpdatePropertyType([FromBody] UpdatePropertyTypeDTO updatePropertyTypeDTO)
            => await _mediator.Send(new UpdatePropertyTypeRequest() { updatePropertyTypeDTO = updatePropertyTypeDTO });


        [HttpPut(ApiRouteV1.PropertyType_Delete, Name = "DeletePropertyType")]
        public async Task<ActionResult<ResponseResultDTO>> DeletePropertyType([FromBody] long id)
            => await _mediator.Send(new DeletePropertyTypeRequest() { Id = id });
    }
}
