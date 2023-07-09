using Application.Const.Response;
using Application.DTOs.Project.Facility;
using MediatR;

namespace Application.features.Projects.FacilityFeatures.Request.Commands
{
    public class CreateFacilityRequest : IRequest<ResponseResultDTO>
    {
        public CreateFacilityDTO createFacilityDTO { get; set; }
    }
}
