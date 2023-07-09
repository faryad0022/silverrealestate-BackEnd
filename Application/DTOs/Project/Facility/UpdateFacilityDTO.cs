using Application.DTOs.Common;

namespace Application.DTOs.Project.Facility
{
    public class UpdateFacilityDTO : BaseEntityDTO, IFacilityDTO
    {
        public string FacilityName { get; set; }
        public long PropertyId { get; set; }

    }
}
