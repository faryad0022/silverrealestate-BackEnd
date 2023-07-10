using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyPlanFeatures.Request.Queries
{
    public class GetPropertyPlanListRequest : IRequest<ResponseResultDTO>
    {
        public long PropertyId { get; set; }
        public bool Selected { get; set; }
    }
}
