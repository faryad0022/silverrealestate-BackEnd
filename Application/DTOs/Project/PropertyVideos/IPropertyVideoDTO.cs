using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Project.PropertyVideos
{
    public interface IPropertyVideoDTO
    {
        public string YoutubeLink { get; set; }
        public string AparatLink { get; set; }
        public long PropertyId { get; set; }
    }
}
