using Application.DTOs.Common;

namespace Application.DTOs.Project.Country
{
    public class UpdateCountryDTO : BaseEntityDTO, ICountryDTO
    {
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
    }
}
