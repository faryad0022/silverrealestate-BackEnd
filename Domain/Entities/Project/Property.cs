using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Project
{
    public class Property : BaseEntity
    {
        #region Properties
        public string Image { get; set; }
        public bool IsSold { get; set; } = false;
        public bool IsRent { get; set; } = false;
        public string OwnerPhoneNumber { get; set; }
        public string AgentPhoneNmber { get; set; }
        #endregion

        #region ForeignKey
        public long PropertyStatusId { get; set; }
        #endregion
        #region Relations
        [ForeignKey(nameof(PropertyStatusId))]
        public PropertyStatus PropertyStatus { get; set; }
        public PropertyDetail PropertyDetail { get; set; }
        public ICollection<PropertyGallery> PropertyGalleries { get; set; }
        public ICollection<PropertyVideo> PropertyVideos { get; set; }
        public ICollection<PropertyFacility> propertyFacilities { get; set; }
        #endregion

    }
}
