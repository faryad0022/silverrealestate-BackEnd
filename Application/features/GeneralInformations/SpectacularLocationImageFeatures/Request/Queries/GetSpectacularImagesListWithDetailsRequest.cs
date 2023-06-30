using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries
{
    public class GetSpectacularImagesListWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public bool justSelected { get; set; } = false;
    }
}
