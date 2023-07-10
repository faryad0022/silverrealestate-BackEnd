using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyPlans
{
    public interface IPropertyPlanDTO
    {
        public string PlanImage { get; set; }
        public string PlanDescription { get; set; }
        public long PropertyId { get; set; }
    }
}
