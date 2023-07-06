using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CityFeatures.Request.Commands
{
    public class DeleteCityRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
