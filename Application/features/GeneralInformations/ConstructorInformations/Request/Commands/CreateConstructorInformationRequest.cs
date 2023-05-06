using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class CreateConstructorInformationRequest : IRequest<ReturnData<CreateConstructorInformationDTO>>
    {
        public CreateConstructorInformationDTO createConstructorInformationDTO { get; set; }
    }
}
