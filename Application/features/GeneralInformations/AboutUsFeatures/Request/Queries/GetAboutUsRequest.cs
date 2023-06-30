using Application.Const.Response;
using MediatR;


namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Queries
{
    public class GetAboutUsRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
