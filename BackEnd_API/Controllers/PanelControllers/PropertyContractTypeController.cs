using Application.Const.Response;
using Application.DTOs.Project.PropertyContractType;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Commands;
using Application.features.Projects.PropertyContractTypeFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    public class PropertyContractTypeController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public PropertyContractTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyContractType_GetAll, Name = "GetAllPropertyContractTypes")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyContractTypes()
            => await _mediator.Send(new GetPropertyContractTypeListRequest());


        [HttpGet(ApiRouteV1.PropertyContractType_Get, Name = "GetPropertyContractType")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyContractType([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyContractTypeRequest() { Id = Id });

        [HttpPost(ApiRouteV1.PropertyContractType_Add, Name = "AddPropertyContractType")]
        public async Task<ActionResult<ResponseResultDTO>> AddPropertyContractType([FromBody] CreatePropertyContractTypeDTO createPropertyContractTypeDTO)
            => await _mediator.Send(new CreatePropertyContractTypeRequest() { createPropertyContractTypeDTO = createPropertyContractTypeDTO });


        [HttpPut(ApiRouteV1.PropertyContractType_Update, Name = "UpdatePropertyContractType")]
        public async Task<ActionResult<ResponseResultDTO>> UpdatePropertyContractType([FromBody] UpdatePropertyContractTypeDTO updatePropertyContractTypeDTO)
            => await _mediator.Send(new UpdatePropertyContractTypeRequest() { updatePropertyContractTypeDTO = updatePropertyContractTypeDTO });


        [HttpPut(ApiRouteV1.PropertyContractType_Delete, Name = "DeletePropertyContractType")]
        public async Task<ActionResult<ResponseResultDTO>> DeletePropertyContractType([FromBody] long id)
            => await _mediator.Send(new DeletePropertyContractTypeRequest() { Id = id });
    }
}
