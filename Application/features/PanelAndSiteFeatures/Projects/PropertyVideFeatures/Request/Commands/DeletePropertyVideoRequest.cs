using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyVideFeatures.Request.Commands
{
    public class DeletePropertyVideoRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
