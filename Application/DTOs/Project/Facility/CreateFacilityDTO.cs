namespace Application.DTOs.Project.Facility
{
    public class CreateFacilityDTO : IFacilityDTO
    {
        public string FacilityName { get; set; }
        public long PropertyId { get; set; }

    }
}
