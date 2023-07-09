using Application.Const.Response;
using Application.DTOs.Project.PropertyGalleries;
using MediatR;

namespace Application.features.Projects.PropertyGalleryFeatures.Request.Commands
{
    public class CreatePropertyGalleryRequest : IRequest<ResponseResultDTO>
    {
        public CreatePropertyGalleryDTO createPropertyGalleryDTO { get; set; }
    }
}
