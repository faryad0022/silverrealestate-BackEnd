using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using MediatR;


namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Queries
{
    public class GetAboutUsRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
