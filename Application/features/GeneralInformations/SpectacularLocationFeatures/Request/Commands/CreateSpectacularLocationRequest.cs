using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class CreateSpectacularLocationRequest : IRequest<ResponseResult>
    {
        public CreateSpectacularLocationDTO createSpectacularLocationDTO { get; set; }
    }
}
