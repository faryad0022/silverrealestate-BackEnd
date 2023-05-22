using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class ChnageSpectacularLocationSelectedStatusRequest : IRequest<ReturnData<SpectacularLocationDTO>>
    {
        public long Id { get; set; }
    }
}
