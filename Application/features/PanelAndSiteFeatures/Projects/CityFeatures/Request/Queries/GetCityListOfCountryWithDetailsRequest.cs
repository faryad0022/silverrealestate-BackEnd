using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Queries
{
    public class GetCityListOfCountryWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public long countryId { get; set; }
    }
}
