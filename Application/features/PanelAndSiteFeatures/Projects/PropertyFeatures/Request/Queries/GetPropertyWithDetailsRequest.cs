using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Queries
{
    public class GetPropertyWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
