using Application.DTOs.Common;

namespace Application.DTOs.Project.City
{
    public class UpdateCityDTO : BaseEntityDTO, ICityDTO
    {
        public string CityName { get; set; }
        public long CountryId { get; set; }
    }
}
