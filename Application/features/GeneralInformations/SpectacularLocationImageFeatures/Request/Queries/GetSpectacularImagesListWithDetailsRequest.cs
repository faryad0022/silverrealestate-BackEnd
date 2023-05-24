using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries
{
    public class GetSpectacularImagesListWithDetailsRequest : IRequest<ReturnData<SpectacularLocationImagesDTO>>
    {
        public bool justSelected { get; set; } = false;
    }
}
