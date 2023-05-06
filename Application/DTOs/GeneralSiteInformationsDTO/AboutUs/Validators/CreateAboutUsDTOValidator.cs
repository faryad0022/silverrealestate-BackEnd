using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.AboutUs.Validators
{
    public class CreateAboutUsDTOValidator : AbstractValidator<CreateAboutUsDTO>
    {

        public CreateAboutUsDTOValidator()
        {
            Include(new IAboutUsDTOValidator()); 
        }
    }
}
