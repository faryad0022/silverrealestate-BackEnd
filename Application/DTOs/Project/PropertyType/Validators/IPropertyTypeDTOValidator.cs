using Application.Const.Response;
using FluentValidation;

namespace Application.DTOs.Project.PropertyType.Validators
{
    public class IPropertyTypeDTOValidator : AbstractValidator<IPropertyTypeDTO>
    {
        public IPropertyTypeDTOValidator()
        {
            RuleFor(x => x.Type)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}
