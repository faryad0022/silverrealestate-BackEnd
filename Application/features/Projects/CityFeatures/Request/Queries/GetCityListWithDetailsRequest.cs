using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CityFeatures.Request.Queries
{
    public class GetCityListWithDetailsRequest : IRequest<ResponseResultDTO>
    {
    }
}
