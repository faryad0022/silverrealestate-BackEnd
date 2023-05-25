namespace Application.DTOs.GeneralSiteInformationsDTO.Logo
{
    public class CreateLogoDTO : ILogoDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
