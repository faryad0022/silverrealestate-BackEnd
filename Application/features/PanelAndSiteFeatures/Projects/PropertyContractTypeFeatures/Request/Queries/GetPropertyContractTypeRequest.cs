using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Request.Queries
{
    public class GetPropertyContractTypeRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
