using Application.Const.Response;
using Application.DTOs.Project.Country;
using MediatR;

namespace Application.features.Projects.CountryFeatures.Request.Commands
{
    public class UpdateCountryRequest : IRequest<ResponseResultDTO>
    {
        public UpdateCountryDTO updateCountryDTO { get; set; }
    }
}
