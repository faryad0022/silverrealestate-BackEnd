using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
