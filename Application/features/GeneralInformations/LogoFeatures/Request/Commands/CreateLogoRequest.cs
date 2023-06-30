using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Commands
{
    public class CreateLogoRequest : IRequest<ResponseResultDTO>
    {
        public CreateLogoDTO createLogoDTO { get; set; }
    }
}
