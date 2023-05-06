using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Queries
{
    public class GetConstructorInformationRequest : IRequest<ReturnData<ConstructorInformationDTO>>
    {
        public long Id { get; set; }
    }
}
