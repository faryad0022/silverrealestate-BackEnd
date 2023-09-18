using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Commands
{
    public class DeletePropertyRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
