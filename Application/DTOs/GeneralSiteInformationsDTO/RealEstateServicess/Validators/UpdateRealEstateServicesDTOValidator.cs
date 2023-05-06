using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess.Validators
{
    public class UpdateRealEstateServicesDTOValidator : AbstractValidator<UpdateRealEstateServicesDTO>
    {
        public UpdateRealEstateServicesDTOValidator()
        {
            Include(new IRealEstateServicesDTOValidatorL());
        }
    }
}
