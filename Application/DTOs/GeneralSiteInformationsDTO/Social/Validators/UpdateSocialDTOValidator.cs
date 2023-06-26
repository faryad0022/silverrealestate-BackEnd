using Application.Const.Response;
using Application.Contract.Persistence.EntitiesRepository.GeneralInformations;
using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Social.Validators
{
    public class UpdateSocialDTOValidator : AbstractValidator<UpdateSocialDTO>
    {
        private readonly ISocialRepository _socialRepository;

        public UpdateSocialDTOValidator(ISocialRepository socialRepository)
        {
            _socialRepository = socialRepository;

            Include(new ISocialDTOValidator());
            RuleFor(x => x.Id)
                .GreaterThan(0)
                    .WithMessage(ValidatorMessages.MustSelected)
                .MustAsync(async (id, token) => await _socialRepository.ExistAsync(id))
                    .WithMessage(ValidatorMessages.NotExist);
        }
    }
}
