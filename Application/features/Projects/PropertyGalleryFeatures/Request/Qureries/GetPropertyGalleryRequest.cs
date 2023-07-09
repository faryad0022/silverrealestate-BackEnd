using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyGalleryFeatures.Request.Qureries
{
    public class GetPropertyGalleryRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
