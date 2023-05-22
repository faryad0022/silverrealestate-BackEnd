using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations
{
    public class UpdateSpectacularLocationDTO : BaseEntityDTO, ISpectacularLocationDTO
    {
        public string Name { get; set; }

    }
}
