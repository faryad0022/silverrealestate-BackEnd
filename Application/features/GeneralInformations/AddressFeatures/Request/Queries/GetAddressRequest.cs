using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.AddressFeatures.Request.Queries
{
    public class GetAddressRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
