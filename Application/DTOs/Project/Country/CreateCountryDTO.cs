namespace Application.DTOs.Project.Country
{
    public class CreateCountryDTO : ICountryDTO
    {
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
    }
}
