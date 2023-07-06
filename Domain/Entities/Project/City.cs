using System.Collections.Generic;
namespace Domain.Entities.Project
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public long CountryId { get; set; }


        public Country Country { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
