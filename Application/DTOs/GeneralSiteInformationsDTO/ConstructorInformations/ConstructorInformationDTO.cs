using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations
{
    public class ConstructorInformationDTO : BaseEntityDTO, IConstructorInformationDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ConstructorLogo { get; set; }
    }
}
