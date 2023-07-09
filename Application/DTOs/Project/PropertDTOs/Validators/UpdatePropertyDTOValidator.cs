using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertDTOs.Validators
{
    public class UpdatePropertyDTOValidator : AbstractValidator<UpdatePropertyDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;

            Include(new IPropertyDTOValidator(_unitofWork));
            RuleFor(x => x.Id)
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
