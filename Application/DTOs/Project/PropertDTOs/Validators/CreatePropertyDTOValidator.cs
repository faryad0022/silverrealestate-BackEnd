using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertDTOs.Validators
{
    public class CreatePropertyDTOValidator : AbstractValidator<CreatePropertyDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyDTOValidator(_unitofWork));
        }
    }
}
