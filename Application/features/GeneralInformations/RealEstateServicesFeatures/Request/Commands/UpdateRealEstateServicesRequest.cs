using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class UpdateRealEstateServicesRequest : IRequest<ReturnData<UpdateRealEstateServicesDTO>>
    {
        public UpdateRealEstateServicesDTO updateRealEstateServicesDTO { get; set; }
    }
}
