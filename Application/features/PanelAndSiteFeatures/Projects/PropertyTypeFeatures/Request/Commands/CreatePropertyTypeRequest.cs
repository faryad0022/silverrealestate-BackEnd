using Application.Const.Response;
using Application.DTOs.Project.PropertyType;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Request.Commands
{
    public class CreatePropertyTypeRequest : IRequest<ResponseResultDTO>
    {
        public CreatePropertyTypeDTO createPropertyTypeDTO { get; set; }
    }
}
