using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries
{
    public class GetSpectacularLocationListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
