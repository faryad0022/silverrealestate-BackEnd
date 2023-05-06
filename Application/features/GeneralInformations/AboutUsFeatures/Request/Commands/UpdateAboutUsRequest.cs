using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Commands
{
    public class UpdateAboutUsRequest : IRequest<ReturnData<UpdateAboutUsDTO>>
    {
        public UpdateAboutUsDTO updateAboutUsDTO { get; set; }
    }
}
