using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class UpdateAddressRequest : IRequest<ReturnData<UpdateAddressDTO>>
    {
        public UpdateAddressDTO updateAddressDTO { get; set; }
    }
}
