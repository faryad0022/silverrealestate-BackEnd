using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class LogoController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public LogoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all-logos")]
        public async Task<ActionResult<ReturnData<LogoDTO>>> GetAllLogo()
            => await _mediator.Send(new GetLogoListRequest());

        [HttpGet("get-logo")]
        public async Task<ActionResult<ReturnData<LogoDTO>>> GetAddress([FromQuery] long Id)
            => await _mediator.Send(new GetLogoRequest() { Id = Id });

        [HttpPost("add-logo")]
        public async Task<ActionResult<ReturnData<CreateLogoDTO>>> AddAddress([FromBody] CreateLogoDTO logoDTO)
            => await _mediator.Send(new CreateLogoRequest() { createLogoDTO = logoDTO });

        [HttpPut("change-logo-selected-status")]
        public async Task<ActionResult<ReturnData<LogoDTO>>> ChangeAddressStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeLogoSelectStatusRequest() { Id = Id });

    }
}
