using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.Logo
{
    public class LogoDTO : BaseEntityDTO, ILogoDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
