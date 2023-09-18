using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationFeatures.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{

    public class SpectacularLocationController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public SpectacularLocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.SpectacularLocation_GetAll, Name = "GetAllSpectacularLocations")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllSpectacularLocations()
            => await _mediator.Send(new GetSpectacularLocationListRequest());

        [HttpGet(ApiRouteV1.SpectacularLocation_Get, Name = "GetSpectacularLocation")]
        public async Task<ActionResult<ResponseResultDTO>> GetSpectacularLocation([FromQuery] long Id)
            => await _mediator.Send(new GetSpectacularLocationRequest() { Id = Id });

        [HttpPost(ApiRouteV1.SpectacularLocation_Add, Name = "AddSpectacularLocation")]
        public async Task<ActionResult<ResponseResultDTO>> AddSpectacularLocation([FromBody] CreateSpectacularLocationDTO createSpectacularLocationDTO)
            => await _mediator.Send(new CreateSpectacularLocationRequest() { createSpectacularLocationDTO = createSpectacularLocationDTO });

        [HttpPut(ApiRouteV1.SpectacularLocation_ChangeStatus, Name = "ChangeSpectacularLocationStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeSpectacularLocationStatus([FromQuery] long Id)
            => await _mediator.Send(new ChnageSpectacularLocationSelectedStatusRequest() { Id = Id });

        [HttpPut(ApiRouteV1.SpectacularLocation_Update, Name = "UpdateSpectacularLocationStatus")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateSpectacularLocationStatus([FromQuery] UpdateSpectacularLocationDTO updateSpectacularLocationDTO)
            => await _mediator.Send(new UpdateSpectacularLocationRequest() { updateSpectacularLocationDTO = updateSpectacularLocationDTO });
    }
}
