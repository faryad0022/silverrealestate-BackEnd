using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Project
{
    public class PropertyFacility : BaseEntity
    {
        #region Properties

        public string FacilityName { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        #endregion
        #region ForeignKey
        public long PropertyId { get; set; }
        #endregion
        #region Relations
        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; }
        #endregion
    }
}
