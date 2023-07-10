using Application.Const.Response;
using Application.DTOs.Project.PropertyPlans;
using MediatR;

namespace Application.features.Projects.PropertyPlanFeatures.Request.Commands
{
    public class UpdatePropertyPlanRequest : IRequest<ResponseResultDTO>
    {
        public UpdatePropertyPlanDTO updatePropertyPlanDTO { get; set; }
    }
}
