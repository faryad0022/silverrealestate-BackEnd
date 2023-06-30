using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Queries
{
    public class GetBannerListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
