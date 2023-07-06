namespace Application.DTOs.Project.City
{
    public class CreateCityDTO : ICityDTO
    {
        public string CityName { get; set; }
        public long CountryId { get; set; }
    }
}
