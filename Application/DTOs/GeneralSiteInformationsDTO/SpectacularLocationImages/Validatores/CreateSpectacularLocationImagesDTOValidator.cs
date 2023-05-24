using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages.Validatores
{
    public class CreateSpectacularLocationImagesDTOValidator : AbstractValidator<CreateSpectacularLocationImagesDTO>
    {
        public CreateSpectacularLocationImagesDTOValidator()
        {
            Include(new ISpectacularLocationImagesDTOValidator());
        }
    }
}
