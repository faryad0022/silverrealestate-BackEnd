using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class ChangeAddressDTOStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
