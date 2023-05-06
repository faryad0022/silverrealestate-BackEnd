using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.AboutUs
{
    public class UpdateAboutUsDTO : BaseEntityDTO, IAboutusDTO
    {
        public string Text { get; set; }
        public string TeamImage { get; set; }
    }
}
