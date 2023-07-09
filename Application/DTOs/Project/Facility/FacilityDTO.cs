using Application.DTOs.Common;

namespace Application.DTOs.Project.Facility
{
    public class FacilityDTO : BaseEntityDTO
    {
        public string FacilityName { get; set; }
        public long PropertyId { get; set; }

    }
}
