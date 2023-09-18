using Application.Const.Response;
using Application.DTOs.Project.Country;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.CountryFeatures.Request.Commands
{
    public class CreateCountryRequest : IRequest<ResponseResultDTO>
    {
        public CreateCountryDTO createCountryDTO { get; set; }
    }
}
