using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages.Validatores
{
    public class UpdateSpectacularLocationImagesDTOValidator : AbstractValidator<UpdateSpectacularLocationImagesDTO>
    {
        public UpdateSpectacularLocationImagesDTOValidator()
        {
            Include(new ISpectacularLocationImagesDTOValidator());
        }
    }
}
