using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Queries
{
    public class GetAddressListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
