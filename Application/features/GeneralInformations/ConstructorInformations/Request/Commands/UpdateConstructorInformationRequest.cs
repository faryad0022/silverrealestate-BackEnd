using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.Reaspose;
using MediatR;


namespace Application.features.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class UpdateConstructorInformationRequest: IRequest<ReturnData<UpdateConstructorInformationDTO>>
    {
        public UpdateConstructorInformationDTO updateConstructorInformationDTO { get; set; }
    }
}
