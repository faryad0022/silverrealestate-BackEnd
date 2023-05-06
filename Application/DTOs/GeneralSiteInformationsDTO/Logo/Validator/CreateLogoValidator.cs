using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Logo.Validator
{
    public class CreateLogoValidator : AbstractValidator<CreateLogoDTO>
    {
        public CreateLogoValidator()
        {
            Include(new ILogoValidator());
        }
    }
}
