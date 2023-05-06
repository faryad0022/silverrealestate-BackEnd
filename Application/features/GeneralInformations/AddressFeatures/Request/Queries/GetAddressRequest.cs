using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Queries
{
    public class GetAddressRequest : IRequest<ReturnData<AddressDTO>>
    {
        public long Id { get; set; }
    }
}
