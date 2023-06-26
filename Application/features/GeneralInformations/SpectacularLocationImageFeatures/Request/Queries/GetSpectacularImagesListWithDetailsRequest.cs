using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries
{
    public class GetSpectacularImagesListWithDetailsRequest : IRequest<ResponseResult>
    {
        public bool justSelected { get; set; } = false;
    }
}
