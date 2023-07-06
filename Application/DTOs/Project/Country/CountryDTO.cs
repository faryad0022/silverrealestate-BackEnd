using Application.DTOs.Common;

namespace Application.DTOs.Project.Country
{
    public class CountryDTO : BaseEntityDTO
    {
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
    }
}
