using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands
{
    public class ChangeRealEstateServiceSelectedStatusRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
