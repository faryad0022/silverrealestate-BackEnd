using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using MediatR;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Queries
{
    public class GetRealEstateServiceRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
