using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class ConstructorInformationController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public ConstructorInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("get-all-constructor-information")]
        public async Task<ActionResult<ReturnData<ConstructorInformationDTO>>> GetAllConstructorInformation()
            => await _mediator.Send(new GetConstructorInformationListRequest());

        [HttpGet("get-constructor-information")]
        public async Task<ActionResult<ReturnData<ConstructorInformationDTO>>> GetConstructorInformation([FromQuery] long Id)
            => await _mediator.Send(new GetConstructorInformationRequest() { Id = Id });

        [HttpPost("add-constructor-information")]
        public async Task<ActionResult<ReturnData<CreateConstructorInformationDTO>>> AddConstructorInformation([FromBody] CreateConstructorInformationDTO createConstructorInformationDTO)
            => await _mediator.Send(new CreateConstructorInformationRequest() { createConstructorInformationDTO = createConstructorInformationDTO });

        [HttpPut("update-constructor-information")]
        public async Task<ActionResult<ReturnData<UpdateConstructorInformationDTO>>> UpdateConstructorInformation([FromQuery] UpdateConstructorInformationDTO updateConstructorInformationDTO)
            => await _mediator.Send(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = updateConstructorInformationDTO });

        [HttpPut("change-constructor-information-status")]
        public async Task<ActionResult<ReturnData<ConstructorInformationDTO>>> ChangeConstructorInformationStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeConstructorInformationSelectedStatusRequest() { Id = Id });
    }
}
