using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Commands
{
    public class ChangeLogoSelectStatusRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
