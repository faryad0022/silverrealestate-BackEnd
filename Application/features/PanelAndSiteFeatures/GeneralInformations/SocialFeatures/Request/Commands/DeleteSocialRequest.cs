using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SocialFeatures.Request.Commands
{
    public class DeleteSocialRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
