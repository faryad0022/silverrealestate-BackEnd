using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.Facility.Validators
{
    public class CreateFacilityDTOValidator : AbstractValidator<CreateFacilityDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreateFacilityDTOValidator(IUnitofWork unitofWork)
        {
            Include(new IFacilityDTOValidator(_unitofWork));
            _unitofWork = unitofWork;
        }
    }
}
