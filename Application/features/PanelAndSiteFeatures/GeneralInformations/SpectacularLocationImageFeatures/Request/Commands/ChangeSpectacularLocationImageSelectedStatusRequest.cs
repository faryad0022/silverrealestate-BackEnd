using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class ChangeSpectacularLocationImageSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
