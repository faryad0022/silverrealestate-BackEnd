using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations.Validators
{
    public class UpdateConstructorInformationValidator : AbstractValidator<UpdateConstructorInformationDTO>
    {
        public UpdateConstructorInformationValidator()
        {
            Include(new IConstructorInformationValidator());
        }
    }
}
