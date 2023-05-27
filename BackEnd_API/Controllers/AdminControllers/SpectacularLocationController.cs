using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class SpectacularLocationController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public SpectacularLocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-all-spectacular-locations")]
        public async Task<ActionResult<ReturnData<SpectacularLocationDTO>>> GetAllSpectacularLocations()
            => await _mediator.Send(new GetSpectacularLocationListRequest());

        [HttpGet("get-spectacular-location")]
        public async Task<ActionResult<ReturnData<SpectacularLocationDTO>>> GetSpectacularLocation([FromQuery] long Id)
            => await _mediator.Send(new GetSpectacularLocationRequest() { Id = Id });

        [HttpPost("add-spectacular-location")]
        public async Task<ActionResult<ReturnData<SpectacularLocationDTO>>> AddSpectacularLocation([FromBody] CreateSpectacularLocationDTO createSpectacularLocationDTO)
            => await _mediator.Send(new CreateSpectacularLocationRequest() { createSpectacularLocationDTO = createSpectacularLocationDTO });

        [HttpPut("change-spectacular-location-selected-status")]
        public async Task<ActionResult<ReturnData<SpectacularLocationDTO>>> ChangeSpectacularLocationStatus([FromQuery] long Id)
            => await _mediator.Send(new ChnageSpectacularLocationSelectedStatusRequest() { Id = Id });

        [HttpPut("update-spectacular-location-selected-status")]
        public async Task<ActionResult<ReturnData<SpectacularLocationDTO>>> UpdateSpectacularLocationStatus([FromQuery] UpdateSpectacularLocationDTO updateSpectacularLocationDTO)
            => await _mediator.Send(new UpdateSpectacularLocationRequest() { updateSpectacularLocationDTO = updateSpectacularLocationDTO });
    }
}
