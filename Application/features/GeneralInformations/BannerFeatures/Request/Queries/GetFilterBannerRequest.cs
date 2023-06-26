using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetFilterBannerRequest : IRequest<ResponseResult>
    {
        public FilterBannerDTO filter { get; set; }
    }
}
