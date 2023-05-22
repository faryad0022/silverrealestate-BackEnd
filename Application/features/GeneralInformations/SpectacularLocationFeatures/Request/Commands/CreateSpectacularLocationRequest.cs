using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class CreateSpectacularLocationRequest : IRequest<ReturnData<SpectacularLocationDTO>>
    {
        public CreateSpectacularLocationDTO createSpectacularLocationDTO { get; set; }
    }
}
