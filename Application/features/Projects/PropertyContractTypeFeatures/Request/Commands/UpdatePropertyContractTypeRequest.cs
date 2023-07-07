using Application.Const.Response;
using Application.DTOs.Project.PropertyContractType;
using MediatR;

namespace Application.features.Projects.PropertyContractTypeFeatures.Request.Commands
{
    public class UpdatePropertyContractTypeRequest : IRequest<ResponseResultDTO>
    {
        public UpdatePropertyContractTypeDTO updatePropertyContractTypeDTO { get; set; }
    }
}
