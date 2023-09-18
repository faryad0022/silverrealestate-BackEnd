using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyTypeFeatures.Request.Queries
{
    public class GetPropertyTypeListRequest : IRequest<ResponseResultDTO>
    {
        public bool justSelected { get; set; }
    }
}
