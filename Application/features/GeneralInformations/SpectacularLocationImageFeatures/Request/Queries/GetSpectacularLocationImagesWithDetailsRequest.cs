using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequest : IRequest<ReturnData<SpectacularLocationImagesDTO>>
    {
        public long Id { get; set; }
    }
}
