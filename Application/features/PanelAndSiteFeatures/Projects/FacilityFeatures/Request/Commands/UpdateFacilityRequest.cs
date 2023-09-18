using Application.Const.Response;
using Application.DTOs.Project.Facility;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.FacilityFeatures.Request.Commands
{
    public class UpdateFacilityRequest : IRequest<ResponseResultDTO>
    {
        public UpdateFacilityDTO updateFacilityDTO { get; set; }
    }
}
