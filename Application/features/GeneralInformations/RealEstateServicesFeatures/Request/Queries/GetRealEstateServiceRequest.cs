using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries
{
    public class GetRealEstateServiceRequest : IRequest<ReturnData<RealEstateServicesDTO>>
    {
        public long Id { get; set; }
    }
}
