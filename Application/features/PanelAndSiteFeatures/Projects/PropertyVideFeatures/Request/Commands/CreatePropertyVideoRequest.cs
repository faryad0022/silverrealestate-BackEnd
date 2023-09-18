using Application.Const.Response;
using Application.DTOs.Project.PropertyVideos;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Commands
{
    public class CreatePropertyVideoRequest : IRequest<ResponseResultDTO>
    {
        public CreatePropertyVideoDTO createPropertyVideoDTO { get; set; }
    }
}
