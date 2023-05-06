using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.Social
{
    public class SocialDTO : BaseEntityDTO, ISocialDTO
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }

    }
}
