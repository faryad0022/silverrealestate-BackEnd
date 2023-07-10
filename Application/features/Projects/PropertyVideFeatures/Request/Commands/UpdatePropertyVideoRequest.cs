using Application.Const.Response;
using Application.DTOs.Project.PropertyVideos;
using MediatR;

namespace Application.features.Projects.PropertyVideFeatures.Request.Commands
{
    public class UpdatePropertyVideoRequest : IRequest<ResponseResultDTO>
    {
        public UpdatePropertyVideoDTO updatePropertyVideoDTO { get; set; }
    }
}
