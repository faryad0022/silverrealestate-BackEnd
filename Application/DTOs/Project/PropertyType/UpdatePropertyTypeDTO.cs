using Application.DTOs.Common;

namespace Application.DTOs.Project.PropertyType
{
    public class UpdatePropertyTypeDTO : BaseEntityDTO, IPropertyTypeDTO
    {
        public string Type { get; set; }//Apartment/Villa/Residency

    }
}
