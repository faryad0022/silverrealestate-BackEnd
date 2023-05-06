using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Queries
{
    public class GetConstructorInformationListRequest : IRequest<ReturnData<ConstructorInformationDTO>>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
