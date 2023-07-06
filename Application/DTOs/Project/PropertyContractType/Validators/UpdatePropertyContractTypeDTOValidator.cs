using FluentValidation;

namespace Application.DTOs.Project.PropertyContractType.Validators
{
    public class UpdatePropertyContractTypeDTOValidator : AbstractValidator<UpdatePropertyContractTypeDTO>
    {
        public UpdatePropertyContractTypeDTOValidator()
        {
            Include(new IPropertyContractTypeDTOValidator());
        }
    }
}
