using FluentValidation;

namespace Application.DTOs.Project.Country.Validators
{
    public class CreateCountryDTOValidator : AbstractValidator<CreateCountryDTO>
    {
        public CreateCountryDTOValidator()
        {
            Include(new ICountryDTOValidator());
        }
    }
}
