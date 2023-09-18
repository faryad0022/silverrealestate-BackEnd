using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Commands
{
    public class DeleteBannerRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
