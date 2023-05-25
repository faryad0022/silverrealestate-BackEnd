using System.Collections.Generic;
namespace Domain.Entities.Project
{
    public class City : BaseEntity
    {
        #region Properties

        public string CityName { get; set; }
        #endregion
        #region ForeignKey
        public long CountryId { get; set; }
        #endregion
        #region Relations
        public Country Country { get; set; }
        public ICollection<PropertyStatus> PropertyStatus { get; set; }

        #endregion
    }
}
