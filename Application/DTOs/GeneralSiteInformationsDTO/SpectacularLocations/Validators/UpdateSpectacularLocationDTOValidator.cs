using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations.Validators
{
    public class UpdateSpectacularLocationDTOValidator : AbstractValidator<UpdateSpectacularLocationDTO>
    {
        public UpdateSpectacularLocationDTOValidator()
        {
            Include(new ISpectacularLocationDTOValidator());
        }
    }
}
