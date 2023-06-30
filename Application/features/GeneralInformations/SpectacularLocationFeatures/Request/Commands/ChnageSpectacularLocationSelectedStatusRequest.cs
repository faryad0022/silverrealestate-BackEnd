using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class ChnageSpectacularLocationSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
