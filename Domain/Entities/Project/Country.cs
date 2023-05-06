using System.Collections.Generic;

namespace Domain.Entities.Project
{
    public class Country : BaseEntity
    {
        #region Properties

        public string CountryName { get; set; }

        public string Icon { get; set; }
        #endregion

        #region Relations
        public ICollection<City> Cities { get; set; }
        #endregion

    }
}
