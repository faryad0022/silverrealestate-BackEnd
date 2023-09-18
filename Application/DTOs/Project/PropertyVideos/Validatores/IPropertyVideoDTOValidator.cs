using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertyVideos.Validatores
{
    public class IPropertyVideoDTOValidator : AbstractValidator<IPropertyVideoDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public IPropertyVideoDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            RuleFor(x => x.PropertyId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
        }
    }
}
