using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyPlanFeatures.Request.Commands
{
    public class DeletePropertyPlanRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
