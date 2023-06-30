using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class UpdateAddressRequest : IRequest<ResponseResultDTO>
    {
        public UpdateAddressDTO updateAddressDTO { get; set; }
    }
}
