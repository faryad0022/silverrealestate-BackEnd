using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
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

        [HttpGet(ApiRouteV1.Logo_GetAll)]
        public async Task<ActionResult<ReturnData<LogoDTO>>> GetAllLogo()
            => await _mediator.Send(new GetLogoListRequest());

        [HttpGet(ApiRouteV1.Logo_Get)]
        public async Task<ActionResult<ReturnData<LogoDTO>>> GetLogo([FromQuery] long Id)
            => await _mediator.Send(new GetLogoRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Logo_Add)]
        public async Task<ActionResult<ReturnData<CreateLogoDTO>>> AddLogo([FromBody] CreateLogoDTO logoDTO)
            => await _mediator.Send(new CreateLogoRequest() { createLogoDTO = logoDTO });

        [HttpPut(ApiRouteV1.Logo_ChangeStatus)]
        public async Task<ActionResult<ReturnData<LogoDTO>>> ChangeLogoStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeLogoSelectStatusRequest() { Id = Id });

    }
}
