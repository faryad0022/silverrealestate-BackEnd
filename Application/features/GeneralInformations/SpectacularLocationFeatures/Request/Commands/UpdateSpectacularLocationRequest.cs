using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class UpdateSpectacularLocationRequest : IRequest<ReturnData<SpectacularLocationDTO>>
    {
        public UpdateSpectacularLocationDTO updateSpectacularLocationDTO { get; set; }
    }
}
