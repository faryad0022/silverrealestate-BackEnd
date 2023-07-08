using Application.DTOs.Paging;
using System;
using System.Collections.Generic;

namespace Application.DTOs.Project.PropertDTOs
{
    public class FilterPropertyDTO : BasePaging
    {
        public List<PropertyDTO> PropertyDTOs { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public long PropertyContractTypeId { get; set; }
        public long PropertyTypeId { get; set; }
        public long CityId { get; set; }
        public int NumberOfBedroom { get; set; }
        public int NumberOfBathroom { get; set; }
        public int FloorSpace { get; set; }//متراژ
        public bool PropertyStatus { get; set; } = true;//true = available , false = notavailable

    }
}
