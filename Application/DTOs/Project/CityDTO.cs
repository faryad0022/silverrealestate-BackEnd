using Application.DTOs.Common;

namespace Application.DTOs.Project
{
    public class CityDTO : BaseEntityDTO
    {
        #region Properties
        public string CityName { get; set; }
        public long CountryId { get; set; }
        public CountryDTO Country { get; set; }
        #endregion

    }
}
