using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Commands
{
    public class DeleteFacilityRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
