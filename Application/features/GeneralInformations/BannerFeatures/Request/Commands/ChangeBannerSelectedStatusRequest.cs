using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Commands
{
    public class ChangeBannerSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
