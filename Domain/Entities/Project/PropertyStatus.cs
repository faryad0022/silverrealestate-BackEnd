using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Project
{
    public class PropertyStatus : BaseEntity
    {
        #region Properties       
        public string Status { get; set; }
        #endregion
        #region ForeignKey

        public long CityId { get; set; }
        #endregion
        #region Relations
        [ForeignKey(nameof(CityId))]
        public City City { get; set; }
        public ICollection<Property> Properties { get; set; }

        #endregion
    }
}
