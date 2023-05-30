using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries;
using Application.Reaspose;
using BackEnd_API.Const;
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
        [HttpGet(ApiRouteV1.SpectacularLocationImage_GetAll_WithDetails,Name = "GetAllSpectacularLocationImageWithDetails")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> GetAllSpectacularLocationImageWithDetails()
            => await _mediator.Send(new GetSpectacularImagesListWithDetailsRequest());

        [HttpGet(ApiRouteV1.SpectacularLocationImage_Get_WithDetails, Name = "GetSpectacularLocationImageWithDetails")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> GetSpectacularLocationImageWithDetails([FromQuery] long Id)
            => await _mediator.Send(new GetSpectacularLocationImagesWithDetailsRequest() { Id = Id });

        [HttpPost(ApiRouteV1.SpectacularLocationImage_Add, Name = "AddSpectacularLocationImage")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> AddSpectacularLocationImage([FromBody] CreateSpectacularLocationImagesDTO createSpectacularLocationImagesDTO)
            => await _mediator.Send(new CreateSpectacularLocationImageRequest() { createSpectacularLocationImagesDTO = createSpectacularLocationImagesDTO });

        [HttpPut(ApiRouteV1.SpectacularLocationImage_Update, Name = "UpdateSpectacularLocationImage")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> UpdateSpectacularLocationImage([FromQuery] UpdateSpectacularLocationImagesDTO updateSpectacularLocationImagesDTO)
            => await _mediator.Send(new UpdateSpectacularLocationImageRequest() { updateSpectacularLocationImagesDTO = updateSpectacularLocationImagesDTO });

        [HttpPut(ApiRouteV1.SpectacularLocationImage_ChangeStatus, Name = "ChangeSpectacularLocationImageStatus")]
        public async Task<ActionResult<ReturnData<SpectacularLocationImagesDTO>>> ChangeSpectacularLocationImageStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeSpectacularLocationImageSelectedStatusRequest() { Id = Id });
    }
}
