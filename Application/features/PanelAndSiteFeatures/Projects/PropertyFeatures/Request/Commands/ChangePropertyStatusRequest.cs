using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Commands
{
    public class ChangePropertyStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
