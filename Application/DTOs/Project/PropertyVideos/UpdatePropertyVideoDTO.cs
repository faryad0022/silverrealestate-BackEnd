using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyVideos
{
    public class UpdatePropertyVideoDTO:BaseEntityDTO,IPropertyVideoDTO
    {
        public string VideoLink { get; set; }
        public long PropertyId { get; set; }
    }
}
