using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Project
{
    public class PropertyDetail : BaseEntity
    {
        #region Properties

        public DateTime StartDate { get; set; }

        public DateTime EndTime { get; set; }

        public string PaymentPlan { get; set; }

        public DateTime KeyHandOver { get; set; }

        public int VAT { get; set; }

        public int ConnectionFee { get; set; }

        public int Stamp { get; set; }

        public string Address { get; set; }
        #endregion

        #region Foreign Key
        public long PropertyId { get; set; }
        #endregion

        #region Relations
        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; }
        #endregion
    }
}
