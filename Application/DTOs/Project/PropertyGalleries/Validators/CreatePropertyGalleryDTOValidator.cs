using Application.Const.Response;
using Application.Contract.Persistence;
using FluentValidation;

namespace Application.DTOs.Project.PropertyGalleries.Validators
{
    public class CreatePropertyGalleryDTOValidator : AbstractValidator<CreatePropertyGalleryDTO>
    {
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyGalleryDTOValidator(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            Include(new IPropertyGalleryDTOValidator(_unitofWork));
            RuleFor(x => x.PropertyId)
                .MustAsync(async (id, token) =>
                {
                    return await _unitofWork.PropertyRepository.ExistAsync(id);
                }).WithMessage(ValidatorMessages.NotExist);
        }
    }
}
