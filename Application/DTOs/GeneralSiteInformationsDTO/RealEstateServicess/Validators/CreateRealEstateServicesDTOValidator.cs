using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess.Validators
{
    public class CreateRealEstateServicesDTOValidator : AbstractValidator<CreateRealEstateServicesDTO>
    {
        public CreateRealEstateServicesDTOValidator()
        {
            Include(new IRealEstateServicesDTOValidatorL());
        }
    }
}
