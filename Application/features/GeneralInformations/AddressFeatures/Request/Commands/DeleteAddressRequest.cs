using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class DeleteAddressRequest : IRequest<ReturnData<AddressDTO>>
    {
        public long Id { get; set; }
    }
}
