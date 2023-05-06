using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.Reaspose;
using MediatR;


namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Queries
{
    public class GetAboutUsRequest : IRequest<ReturnData<AboutUsDTO>>
    {
        public long Id { get; set; }
    }
}
