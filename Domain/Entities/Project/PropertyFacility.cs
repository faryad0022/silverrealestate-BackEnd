namespace Domain.Entities.Project
{
    public class PropertyFacility : BaseEntity
    {
        public string FacilityName { get; set; }
        public long PropertyId { get; set; }

        public Property Property { get; set; }
    }
}
