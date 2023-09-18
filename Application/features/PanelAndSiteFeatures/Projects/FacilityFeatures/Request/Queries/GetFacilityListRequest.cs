using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Queries
{
    public class GetFacilityListRequest : IRequest<ResponseResultDTO>
    {
        public bool Selected { get; set; }
    }
}
