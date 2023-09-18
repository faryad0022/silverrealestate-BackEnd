using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Qureries
{
    public class GetPropertyGalleryListRequest : IRequest<ResponseResultDTO>
    {
        public long PropertyId { get; set; }
        public bool Selected { get; set; }
    }
}
