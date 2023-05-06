using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Social.Validators
{
    public class CreateSocialDTOValidator : AbstractValidator<CreateSocialDTO>
    {
        public CreateSocialDTOValidator()
        {
            Include(new ISocialDTOValidator());
        }
    }
}
