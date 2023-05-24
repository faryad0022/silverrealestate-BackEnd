using Application.DTOs.Common;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages
{
    public class SpectacularLocationImagesDTO : BaseEntityDTO, ISpectacularLocationImagesDTO
    {
        public string Image { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public long SpectacularlocationId { get; set; }
        public string SpectacularlocationName { get; set; }
    }
}
