using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Project
{
    public class PropertyVideo : BaseEntity
    {
        #region Properties
        public string VideoName { get; set; }

        public string VideoAddress { get; set; }
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
