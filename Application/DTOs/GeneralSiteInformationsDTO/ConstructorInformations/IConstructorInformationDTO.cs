using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations
{
    public interface IConstructorInformationDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ConstructorLogo { get; set; }
    }
}
