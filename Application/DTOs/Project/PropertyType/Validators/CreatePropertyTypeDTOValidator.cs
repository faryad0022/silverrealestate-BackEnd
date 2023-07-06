using FluentValidation;

namespace Application.DTOs.Project.PropertyType.Validators
{
    public class CreatePropertyTypeDTOValidator : AbstractValidator<IPropertyTypeDTO>
    {
        public CreatePropertyTypeDTOValidator()
        {
            Include(new IPropertyTypeDTOValidator());
        }
    }
}
