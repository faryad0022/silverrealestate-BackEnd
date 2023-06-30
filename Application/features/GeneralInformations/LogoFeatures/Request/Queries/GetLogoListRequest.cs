using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Queries
{
    public class GetLogoListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
