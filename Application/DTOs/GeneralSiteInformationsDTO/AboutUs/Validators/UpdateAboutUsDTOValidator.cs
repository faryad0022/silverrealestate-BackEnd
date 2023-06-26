using Application.Const.Response;
using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.AboutUs.Validators
{
    public class UpdateAboutUsDTOValidator : AbstractValidator<UpdateAboutUsDTO>
    {
        private readonly IAboutUsRepository _aboutUsRepository;

        public UpdateAboutUsDTOValidator(IAboutUsRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;

            Include(new IAboutUsDTOValidator());
            RuleFor(x => x.Id)
                .GreaterThan(0)
                    .WithMessage(ValidatorMessages.MustSelected);
        }
    }
}
