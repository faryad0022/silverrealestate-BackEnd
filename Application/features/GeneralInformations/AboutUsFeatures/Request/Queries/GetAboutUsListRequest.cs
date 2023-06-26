using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Queries
{
    public class GetAboutUsListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
