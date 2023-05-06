using Application.Const.Validator;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions.Validators
{
    public class ICommonQuestionValidator : AbstractValidator<ICommonQuestionDTO>
    {
        public ICommonQuestionValidator()
        {
            RuleFor(x => x.Question)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.Answer)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}
