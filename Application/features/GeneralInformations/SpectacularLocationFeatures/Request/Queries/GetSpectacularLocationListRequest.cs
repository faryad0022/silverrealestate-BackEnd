using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Queries
{
    public class GetSpectacularLocationListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
