using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyPlanFeatures.Request.Queries
{
    public class GetPropertyPlanRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
