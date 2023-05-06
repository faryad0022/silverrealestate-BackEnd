using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class ChangeAddressDTOStatusRequest : IRequest<ReturnData<UpdateAddressDTO>>
    {
        public long Id { get; set; }
    }
}
