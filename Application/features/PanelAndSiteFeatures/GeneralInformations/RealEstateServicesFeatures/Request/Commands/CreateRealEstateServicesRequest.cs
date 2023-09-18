using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class CreateRealEstateServicesRequest : IRequest<ResponseResultDTO>
    {
        public CreateRealEstateServicesDTO createRealEstateServicesDTO { get; set; }
    }
}
