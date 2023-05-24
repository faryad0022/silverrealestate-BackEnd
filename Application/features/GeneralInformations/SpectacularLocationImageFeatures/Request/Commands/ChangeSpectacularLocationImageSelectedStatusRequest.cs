using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class ChangeSpectacularLocationImageSelectedStatusRequest : IRequest<ReturnData<SpectacularLocationImagesDTO>>
    {
        public long Id { get; set; }
    }
}
