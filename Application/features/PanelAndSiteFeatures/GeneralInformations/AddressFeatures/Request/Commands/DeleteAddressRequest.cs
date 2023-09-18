using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.AddressFeatures.Request.Commands
{
    public class DeleteAddressRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
