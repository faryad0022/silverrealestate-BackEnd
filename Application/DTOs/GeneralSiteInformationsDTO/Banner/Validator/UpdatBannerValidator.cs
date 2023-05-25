using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator
{
    public class UpdatBannerValidator : AbstractValidator<IBannerDTO>
    {
        public UpdatBannerValidator()
        {
            Include(new IBannerDTOValidator());

        }
    }
}
