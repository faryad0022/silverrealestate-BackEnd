using Application.Const.Response;
using Application.DTOs.Project.PropertyType;
using MediatR;

namespace Application.features.Projects.PropertyTypeFeatures.Request.Commands
{
    public class UpdatePropertyTypeRequest : IRequest<ResponseResultDTO>
    {
        public UpdatePropertyTypeDTO updatePropertyTypeDTO { get; set; }
    }
}
