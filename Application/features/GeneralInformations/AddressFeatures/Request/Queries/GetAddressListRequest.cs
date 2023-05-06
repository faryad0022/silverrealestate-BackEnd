using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Queries
{
    public class GetAddressListRequest : IRequest<ReturnData<AddressDTO>>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
