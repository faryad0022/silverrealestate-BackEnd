using FluentValidation;

namespace Application.DTOs.Project.PropertyType.Validators
{
    public class UpdatePropertyTypeDTOValidator : AbstractValidator<UpdatePropertyTypeDTO>
    {
        public UpdatePropertyTypeDTOValidator()
        {
            Include(new IPropertyTypeDTOValidator());
        }
    }
}
