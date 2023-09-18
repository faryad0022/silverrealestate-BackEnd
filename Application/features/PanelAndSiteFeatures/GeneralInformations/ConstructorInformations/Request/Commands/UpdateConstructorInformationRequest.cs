using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using MediatR;


namespace Application.features.PanelAndSiteFeatures.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class UpdateConstructorInformationRequest : IRequest<ResponseResultDTO>
    {
        public UpdateConstructorInformationDTO updateConstructorInformationDTO { get; set; }
    }
}
