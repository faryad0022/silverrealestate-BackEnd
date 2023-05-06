using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.Social
{
    public class UpdateSocialDTO : BaseEntityDTO, ISocialDTO
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
