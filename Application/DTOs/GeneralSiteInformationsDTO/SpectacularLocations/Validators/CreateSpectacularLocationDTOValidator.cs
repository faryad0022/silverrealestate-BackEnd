using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations.Validators
{
    public class CreateSpectacularLocationDTOValidator : AbstractValidator<CreateSpectacularLocationDTO>
    {
        public CreateSpectacularLocationDTOValidator()
        {
            Include(new ISpectacularLocationDTOValidator());
        }
    }
}
