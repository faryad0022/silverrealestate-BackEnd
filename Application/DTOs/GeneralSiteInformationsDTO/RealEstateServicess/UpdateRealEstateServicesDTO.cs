using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess
{
    public class UpdateRealEstateServicesDTO : BaseEntityDTO, IRealEstateServicesDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
