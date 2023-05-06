using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Queries
{
    public class GetLogoListRequest : IRequest<ReturnData<LogoDTO>>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
