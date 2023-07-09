using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertyGalleries.Validators
{
    public class IPropertyGalleryDTOValidator : AbstractValidator<IPropertyGalleryDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public IPropertyGalleryDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            RuleFor(x => x.ImageName)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull);
            RuleFor(x => x.PropertyId)
                .GreaterThan(0).WithMessage(ValidatorMessages.GreaterThan)
                .NotEmpty().WithMessage(ValidatorMessages.NotEmpty)
                .NotNull().WithMessage(ValidatorMessages.NotNull)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
