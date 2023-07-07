using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertyType.Validators
{
    public class UpdatePropertyTypeDTOValidator : AbstractValidator<UpdatePropertyTypeDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyTypeDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyTypeDTOValidator());
            RuleFor(x => x.Id)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyTypeRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
