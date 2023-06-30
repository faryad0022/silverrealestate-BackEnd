using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class CreateAddressRequest : IRequest<ResponseResultDTO>
    {
        public CreateAddressDTO createAddressDTO { get; set; }
    }
}
