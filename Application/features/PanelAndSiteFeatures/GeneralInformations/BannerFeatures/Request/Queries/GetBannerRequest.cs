using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetBannerRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
