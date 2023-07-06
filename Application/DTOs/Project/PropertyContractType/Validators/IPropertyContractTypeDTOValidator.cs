using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.Project.PropertyContractType.Validators
{
    public class IPropertyContractTypeDTOValidator : AbstractValidator<IPropertyContractTypeDTO>
    {
        public IPropertyContractTypeDTOValidator()
        {
            RuleFor(x => x.ContractType)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}
