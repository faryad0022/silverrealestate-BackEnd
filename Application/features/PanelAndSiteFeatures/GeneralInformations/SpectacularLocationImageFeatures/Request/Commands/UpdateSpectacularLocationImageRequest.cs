using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class UpdateSpectacularLocationImageRequest : IRequest<ResponseResultDTO>
    {
        public UpdateSpectacularLocationImagesDTO updateSpectacularLocationImagesDTO { get; set; }
    }
}
