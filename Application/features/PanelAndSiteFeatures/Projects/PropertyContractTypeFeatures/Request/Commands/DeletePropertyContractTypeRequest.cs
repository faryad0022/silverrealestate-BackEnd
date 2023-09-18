using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Request.Commands
{
    public class DeletePropertyContractTypeRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
