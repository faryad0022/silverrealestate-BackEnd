using Application.Const.Validator;
using Application.DTOs.Blog.BlogContent.Common;
using FluentValidation;

namespace Application.DTOs.Blog.BlogContent.Validators
{
    public class IBlogContentValidator : AbstractValidator<IBlogcontentDTO>
    {
        public IBlogContentValidator()
        {
            RuleFor(x => x.Title)
                .MaximumLength(100).WithMessage(ValidatorMessages.MaximumLength)
                .MinimumLength(5).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);

            RuleFor(x => x.Text)
                .MinimumLength(20).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);

            RuleFor(x => x.BlogGroupId)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan);

            RuleFor(x => x.ImageName)
                .MaximumLength(500).WithMessage(ValidatorMessages.MaximumLength)
                .MinimumLength(5).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);

        }
    }

}
