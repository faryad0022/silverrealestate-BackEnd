using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.Logo
{
    public class UpdateLogoDTO : BaseEntityDTO, ILogoDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
