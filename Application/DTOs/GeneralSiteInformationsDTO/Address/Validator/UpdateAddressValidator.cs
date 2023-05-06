using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Address.Validator
{
    public class UpdateAddressValidator : AbstractValidator<UpdateAddressDTO>
    {
        public UpdateAddressValidator()
        {
            Include(new IAddressValidator());
        }
    }
}
