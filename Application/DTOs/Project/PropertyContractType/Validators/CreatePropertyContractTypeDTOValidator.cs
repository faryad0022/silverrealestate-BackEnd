using FluentValidation;

namespace Application.DTOs.Project.PropertyContractType.Validators
{
    public class CreatePropertyContractTypeDTOValidator : AbstractValidator<CreatePropertyContractTypeDTO>
    {
        public CreatePropertyContractTypeDTOValidator()
        {
            Include(new IPropertyContractTypeDTOValidator());
        }
    }
}
