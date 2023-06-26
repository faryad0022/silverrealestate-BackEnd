using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using MediatR;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands
{
    public class ChangeSpectacularLocationImageSelectedStatusRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
