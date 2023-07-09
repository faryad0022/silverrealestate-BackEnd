using Application.DTOs.Common;
using System;

namespace Application.DTOs.Project.PropertDTOs
{
    public class UpdatePropertyDTO : BaseEntityDTO, IPropertyDTO
    {
        public string FeatureImage { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public string AgentPhoneNmber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PaymentPlan { get; set; }
        public DateTime KeyHandOverDate { get; set; }
        public double Price { get; set; }
        public int VATFee { get; set; }
        public int ConnectionFee { get; set; }
        public int StampDutyFee { get; set; }
        public string Address { get; set; }
        public int NumberOfBedroom { get; set; }
        public int NumberOfBathroom { get; set; }
        public int FloorSpace { get; set; }//mm
        public int Floor { get; set; }
        public string Description { get; set; }
        public bool PropertyStatus { get; set; }//available or no


        public long PropertyTypeId { get; set; }
        public long CityId { get; set; }
        public long PropertyContractTypeId { get; set; }

    }
}
