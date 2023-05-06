using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Address.Validator
{
    public class CreateAddressValidator : AbstractValidator<CreateAddressDTO>
    {
        public CreateAddressValidator()
        {
            Include(new IAddressValidator());
        }
    }
}
