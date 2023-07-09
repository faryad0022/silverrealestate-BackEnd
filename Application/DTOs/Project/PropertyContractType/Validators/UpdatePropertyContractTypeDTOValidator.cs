using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertyContractType.Validators
{
    public class UpdatePropertyContractTypeDTOValidator : AbstractValidator<UpdatePropertyContractTypeDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyContractTypeDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyContractTypeDTOValidator());
            RuleFor(x => x.Id)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyContractTypeRepository.ExistAsync(id);
                });
        }
    }
}
