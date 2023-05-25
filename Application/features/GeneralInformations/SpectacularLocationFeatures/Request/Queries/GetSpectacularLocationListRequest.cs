using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries
{
    public class GetSpectacularLocationListRequest : IRequest<ReturnData<SpectacularLocationDTO>>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
