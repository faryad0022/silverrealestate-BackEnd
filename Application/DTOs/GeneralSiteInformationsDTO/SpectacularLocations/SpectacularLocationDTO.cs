using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations
{
    public class SpectacularLocationDTO : BaseEntityDTO, ISpectacularLocationDTO
    {
        public string Name { get; set; }

    }
}
