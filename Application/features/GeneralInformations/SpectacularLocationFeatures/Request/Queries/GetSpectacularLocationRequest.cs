using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries
{
    public class GetSpectacularLocationRequest : IRequest<ReturnData<SpectacularLocationDTO>>
    {
        public long Id { get; set; }
    }
}
