using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Commands
{
    public class CreateAboutUsRequest : IRequest<ReturnData<CreateAboutUsDTO>>
    {
        public CreateAboutUsDTO createAboutUsDTO { get; set; }
    }

}
