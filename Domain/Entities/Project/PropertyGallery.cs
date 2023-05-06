using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Project
{
    public class PropertyGallery : BaseEntity
    {
        #region Properties

        public string ImageName { get; set; }

        public string ImageAddress { get; set; }
        #endregion

        #region Foreign Key
        public long PropertyId { get; set; }
        #endregion

        #region Relations
        [ForeignKey(nameof(PropertyId))]
        public Property property { get; set; }
        #endregion
    }
}
