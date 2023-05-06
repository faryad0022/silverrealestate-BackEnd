using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations.Validators
{
    public class CreateConstructorInformationValidator : AbstractValidator<CreateConstructorInformationDTO>
    {
        public CreateConstructorInformationValidator()
        {
            Include(new IConstructorInformationValidator());
        }
    }
}
