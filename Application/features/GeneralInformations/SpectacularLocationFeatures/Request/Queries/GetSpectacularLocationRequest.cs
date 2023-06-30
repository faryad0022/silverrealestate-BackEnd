using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries
{
    public class GetSpectacularLocationRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
