using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetFilterBannerRequest : IRequest<ResponseResultDTO>
    {
        public FilterBannerDTO filter { get; set; }
    }
}
