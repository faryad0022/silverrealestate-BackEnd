using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class CreateSpectacularLocationImageRequest : IRequest<ResponseResultDTO>
    {
        public CreateSpectacularLocationImagesDTO createSpectacularLocationImagesDTO { get; set; }
    }
}
