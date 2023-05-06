using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Queries
{
    public class GetAboutUsListRequest : IRequest<ReturnData<AboutUsDTO>>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
