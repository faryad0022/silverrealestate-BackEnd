using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class ChangeRealEstateServiceSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
