using System.Collections.Generic;

namespace Domain.Entities.Project
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }

        public ICollection<City> Cities { get; set; }

    }
}
