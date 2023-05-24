using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class UpdateSpectacularLocationImageRequest : IRequest<ReturnData<SpectacularLocationImagesDTO>>
    {
        public UpdateSpectacularLocationImagesDTO updateSpectacularLocationImagesDTO { get; set; }
    }
}
