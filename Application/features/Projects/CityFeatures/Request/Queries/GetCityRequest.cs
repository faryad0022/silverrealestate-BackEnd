using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CityFeatures.Request.Queries
{
    public class GetCityRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
