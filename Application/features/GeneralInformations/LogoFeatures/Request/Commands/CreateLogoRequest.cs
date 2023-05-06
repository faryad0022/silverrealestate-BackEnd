using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Commands
{
    public class CreateLogoRequest : IRequest<ReturnData<CreateLogoDTO>>
    {
        public CreateLogoDTO createLogoDTO { get; set; }
    }
}
