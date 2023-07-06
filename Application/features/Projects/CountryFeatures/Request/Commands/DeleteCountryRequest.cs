using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CountryFeatures.Request.Commands
{
    public class DeleteCountryRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
