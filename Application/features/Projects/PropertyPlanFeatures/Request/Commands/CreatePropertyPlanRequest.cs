using Application.Const.Response;
using Application.DTOs.Project.PropertyPlans;
using MediatR;

namespace Application.features.Projects.PropertyPlanFeatures.Request.Commands
{
    public class CreatePropertyPlanRequest : IRequest<ResponseResultDTO>
    {
        public CreatePropertyPlanDTO createPropertyPlanDTO { get; set; }
    }
}
