using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Commands
{
    public class DeletePropertyGalleryRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
