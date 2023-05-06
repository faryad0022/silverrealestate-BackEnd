using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Logo.Validator
{
    public class UpdateLogoValidator : AbstractValidator<UpdateLogoDTO>
    {
        public UpdateLogoValidator()
        {
            Include(new ILogoValidator());
        }
    }
}
