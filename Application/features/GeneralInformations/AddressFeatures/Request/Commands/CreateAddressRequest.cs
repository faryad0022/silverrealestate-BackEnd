using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class CreateAddressRequest : IRequest<ReturnData<AddressDTO>>
    {
        public CreateAddressDTO createAddressDTO { get; set; }
    }
}
