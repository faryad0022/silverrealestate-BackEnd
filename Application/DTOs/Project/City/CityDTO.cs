using Application.DTOs.Common;

namespace Application.DTOs.Project.City
{
    public class CityDTO : BaseEntityDTO
    {
        public string CityName { get; set; }
        public long CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
