using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Queries
{
    public class GetAddressListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
