using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CityFeatures.Request.Queries
{
    public class GetCityListOfCountryRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; }
        public long countryId { get; set; }
    }
}
