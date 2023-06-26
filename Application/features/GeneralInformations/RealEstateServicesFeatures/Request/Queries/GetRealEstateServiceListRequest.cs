using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries
{
    public class GetRealEstateServiceListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
