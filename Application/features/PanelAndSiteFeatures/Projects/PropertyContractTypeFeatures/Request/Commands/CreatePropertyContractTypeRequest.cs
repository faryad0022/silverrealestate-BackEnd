using Application.Const.Response;
using Application.DTOs.Project.PropertyContractType;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Request.Commands
{
    public class CreatePropertyContractTypeRequest : IRequest<ResponseResultDTO>
    {
        public CreatePropertyContractTypeDTO createPropertyContractTypeDTO { get; set; }
    }
}
