using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class ChangeRealEstateServiceSelectedStatusRequest : IRequest<ReturnData<RealEstateServicesDTO>>
    {
        public long Id { get; set; }
    }
}
