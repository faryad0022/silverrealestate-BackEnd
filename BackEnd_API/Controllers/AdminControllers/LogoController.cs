using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.features.GeneralInformations.LogoFeatures.Request.Commands;
using Application.features.GeneralInformations.LogoFeatures.Request.Queries;
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

        [HttpGet(ApiRouteV1.Logo_GetAll, Name = "GetAllLogo")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllLogo()
            => await _mediator.Send(new GetLogoListRequest());

        [HttpGet(ApiRouteV1.Logo_Get, Name = "GetLogo")]
        public async Task<ActionResult<ResponseResultDTO>> GetLogo([FromQuery] long Id)
            => await _mediator.Send(new GetLogoRequest() { Id = Id });

        [HttpPost(ApiRouteV1.Logo_Add, Name = "AddLogo")]
        public async Task<ActionResult<ResponseResultDTO>> AddLogo([FromBody] CreateLogoDTO logoDTO)
            => await _mediator.Send(new CreateLogoRequest() { createLogoDTO = logoDTO });

        [HttpPut(ApiRouteV1.Logo_ChangeStatus, Name = "ChangeLogoStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeLogoStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeLogoSelectStatusRequest() { Id = Id });

    }
}
