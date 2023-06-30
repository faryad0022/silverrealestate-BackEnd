using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class UpdateSpectacularLocationRequest : IRequest<ResponseResultDTO>
    {
        public UpdateSpectacularLocationDTO updateSpectacularLocationDTO { get; set; }
    }
}
