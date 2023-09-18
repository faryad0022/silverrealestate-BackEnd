using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyContractTypeFeatures.Request.Queries
{
    public class GetPropertyContractTypeListRequest : IRequest<ResponseResultDTO>
    {
        public bool justSelected { get; set; }
    }
}
