using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Commands
{
    public class UpdateAboutUsRequest : IRequest<ResponseResult>
    {
        public UpdateAboutUsDTO updateAboutUsDTO { get; set; }
    }
}
