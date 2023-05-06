namespace Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations
{
    public class CreateConstructorInformationDTO : IConstructorInformationDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ConstructorLogo { get; set; }
    }
}
