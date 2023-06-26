using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class CreateSpectacularLocationImageRequest : IRequest<ResponseResult>
    {
        public CreateSpectacularLocationImagesDTO createSpectacularLocationImagesDTO { get; set; }
    }
}
