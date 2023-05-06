using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        public ICollection<PropertyStatus> PropertyStatus { get; set; }

        #endregion
    }
}
