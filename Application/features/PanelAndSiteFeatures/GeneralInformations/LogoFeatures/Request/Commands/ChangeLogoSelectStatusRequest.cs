using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.LogoFeatures.Request.Commands
{
    public class ChangeLogoSelectStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
