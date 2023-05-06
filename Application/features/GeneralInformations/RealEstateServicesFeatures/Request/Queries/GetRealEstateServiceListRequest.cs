using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries
{
    public class GetRealEstateServiceListRequest : IRequest<ReturnData<RealEstateServicesDTO>>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
