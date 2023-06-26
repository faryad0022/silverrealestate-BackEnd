using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetBannerListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
