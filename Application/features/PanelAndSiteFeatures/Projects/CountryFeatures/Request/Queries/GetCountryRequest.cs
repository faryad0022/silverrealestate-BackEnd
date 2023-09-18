using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.CountryFeatures.Request.Queries
{
    public class GetCountryRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
