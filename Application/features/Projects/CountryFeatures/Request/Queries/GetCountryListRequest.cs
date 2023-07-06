using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CountryFeatures.Request.Queries
{
    public class GetCountryListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; }
    }
}
