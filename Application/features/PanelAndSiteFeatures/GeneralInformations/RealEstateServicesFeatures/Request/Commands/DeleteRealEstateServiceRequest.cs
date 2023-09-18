using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class DeleteRealEstateServiceRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
