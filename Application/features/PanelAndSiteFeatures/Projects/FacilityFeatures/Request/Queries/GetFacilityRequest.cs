using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Queries
{
    public class GetFacilityRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
