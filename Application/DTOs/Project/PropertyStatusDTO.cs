using Application.DTOs.Common;

namespace Application.DTOs.Project
{
    public class PropertyStatusDTO : BaseEntityDTO
    {
        #region Properties       
        public string Status { get; set; }
        public long CityId { get; set; }
        public CityDTO City { get; set; }

        #endregion

    }
}
