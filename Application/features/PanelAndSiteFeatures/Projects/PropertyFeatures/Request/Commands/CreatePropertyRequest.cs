using Application.Const.Response;
using Application.DTOs.Project.PropertDTOs;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Commands
{
    public class CreatePropertyRequest : IRequest<ResponseResultDTO>
    {
        public CreatePropertyDTO createPropertyDTO { get; set; }
    }
}
