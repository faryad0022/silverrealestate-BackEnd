using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Commands
{
    public class ChangeLogoSelectStatusRequest : IRequest<ReturnData<LogoDTO>>
    {
        public long Id { get; set; }
    }
}
