using Application.DTOs.GeneralSiteInformationsDTO.Logo;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Queries
{
    public class GetLogoRequest : IRequest<ReturnData<LogoDTO>>
    {
        public long Id { get; set; }
    }
}
