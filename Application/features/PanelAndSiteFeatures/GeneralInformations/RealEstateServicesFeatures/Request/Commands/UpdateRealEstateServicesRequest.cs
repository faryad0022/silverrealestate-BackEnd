using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class UpdateRealEstateServicesRequest : IRequest<ResponseResultDTO>
    {
        public UpdateRealEstateServicesDTO updateRealEstateServicesDTO { get; set; }
    }
}
