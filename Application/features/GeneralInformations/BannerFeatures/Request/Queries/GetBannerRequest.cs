using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetBannerRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
