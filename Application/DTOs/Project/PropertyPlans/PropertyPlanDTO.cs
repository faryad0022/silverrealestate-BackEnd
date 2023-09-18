using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyPlans
{
    public class PropertyPlanDTO : BaseEntityDTO
    {
        public string PlanImage { get; set; }
        public string PlanDescription { get; set; }
        public long PropertyId { get; set; }
    }
}
