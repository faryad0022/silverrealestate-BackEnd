using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class ChnageSpectacularLocationSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
