using System.Collections.Generic;

namespace Domain.Entities.Project
{
    public class PropertyType : BaseEntity
    {
        public string Type { get; set; }//Apartment/Villa/Residency

        public ICollection<Property> Properties { get; set; }

    }
}
