using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class CreateSpectacularLocationImageRequest : IRequest<ReturnData<SpectacularLocationImagesDTO>>
    {
        public CreateSpectacularLocationImagesDTO createSpectacularLocationImagesDTO { get; set; }
    }
}
