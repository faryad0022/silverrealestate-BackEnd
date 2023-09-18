using Application.Const.Response;
using Application.DTOs.Project.PropertDTOs;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Commands
{
    public class UpdatePropertyRequest : IRequest<ResponseResultDTO>
    {
        public UpdatePropertyDTO updatePropertyDTO { get; set; }
    }
}
