using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class CreateRealEstateServicesRequest : IRequest<ReturnData<CreateRealEstateServicesDTO>>
    {
        public CreateRealEstateServicesDTO createRealEstateServicesDTO { get; set; }
    }
}
