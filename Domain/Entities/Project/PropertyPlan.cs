namespace Domain.Entities.Project
{
    public class PropertyPlan : BaseEntity
    {
        public string PlanImage { get; set; }
        public string PlanDescription { get; set; }
        public long PropertyId { get; set; }

        public Property Property { get; set; }
    }
}
