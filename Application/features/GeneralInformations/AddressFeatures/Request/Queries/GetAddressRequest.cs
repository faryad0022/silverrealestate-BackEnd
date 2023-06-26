using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Queries
{
    public class GetAddressRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
