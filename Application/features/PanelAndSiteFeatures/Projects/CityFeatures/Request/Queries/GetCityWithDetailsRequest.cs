using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Queries
{
    public class GetCityWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public long cityId { get; set; }
    }
}
