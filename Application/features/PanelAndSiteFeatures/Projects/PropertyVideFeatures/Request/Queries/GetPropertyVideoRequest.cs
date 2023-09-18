using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Queries
{
    public class GetPropertyVideoRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
