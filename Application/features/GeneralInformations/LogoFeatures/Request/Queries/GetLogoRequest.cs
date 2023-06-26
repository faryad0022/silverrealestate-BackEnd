using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Queries
{
    public class GetLogoRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
