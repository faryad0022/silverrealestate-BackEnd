using Application.DTOs.Common;

namespace Application.DTOs.Project
{
    public class CountryDTO : BaseEntityDTO
    {
        #region Properties
        public string CountryName { get; set; }
        public string Icon { get; set; }
        #endregion
    }
}
