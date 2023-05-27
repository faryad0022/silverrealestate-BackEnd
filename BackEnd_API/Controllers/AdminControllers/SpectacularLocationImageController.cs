using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class SpectacularLocationImageController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public SpectacularLocationImageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("get-all-spectacular-images")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> GetAllSpectacularLocationImageWithDetails()
            => await _mediator.Send(new GetSpectacularImagesListWithDetailsRequest());

        [HttpGet("get-spectacular-images")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> GetSpectacularLocationImageWithDetails([FromQuery] long Id)
            => await _mediator.Send(new GetSpectacularLocationImagesWithDetailsRequest() { Id = Id });

        [HttpPost("add-spectacular-images")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> AddSpectacularLocationImage([FromBody] CreateSpectacularLocationImagesDTO createSpectacularLocationImagesDTO)
            => await _mediator.Send(new CreateSpectacularLocationImageRequest() { createSpectacularLocationImagesDTO = createSpectacularLocationImagesDTO });

        [HttpPut("update-spectacular-images")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> UpdateSpectacularLocationImage([FromQuery] UpdateSpectacularLocationImagesDTO updateSpectacularLocationImagesDTO)
            => await _mediator.Send(new UpdateSpectacularLocationImageRequest() { updateSpectacularLocationImagesDTO = updateSpectacularLocationImagesDTO });

        [HttpPut("change-spectacular-images-status")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> ChangeSpectacularLocationImageStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeSpectacularLocationImageSelectedStatusRequest() { Id = Id });
    }
}
