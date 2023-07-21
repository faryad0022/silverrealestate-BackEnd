using Application.Const.Response;
using Application.DTOs.Blog.BlogGroup.Common;
using FluentValidation;

namespace Application.DTOs.Blog.BlogGroup.Validators
{
    public class IBlogGroupValidator : AbstractValidator<IBlogGroupDTO>
    {
        public IBlogGroupValidator()
        {
            RuleFor(p => p.Name)
                .MaximumLength(500).WithMessage(ValidatorMessages.MaximumLength)
                .MinimumLength(2).WithMessage(ValidatorMessages.MinimumLength)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}
