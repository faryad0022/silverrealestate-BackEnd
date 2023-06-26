using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Commands
{
    public class UpdateAddressRequest : IRequest<ResponseResult>
    {
        public UpdateAddressDTO updateAddressDTO { get; set; }
    }
}
