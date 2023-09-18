namespace Application.DTOs.Project.PropertyPlans
{
    public class CreatePropertyPlanDTO : IPropertyPlanDTO
    {
        public string PlanImage { get; set; }
        public string PlanDescription { get; set; }
        public long PropertyId { get; set; }
    }
}
