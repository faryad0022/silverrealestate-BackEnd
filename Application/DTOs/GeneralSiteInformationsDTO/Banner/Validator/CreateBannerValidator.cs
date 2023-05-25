using FluentValidation;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator
{
    public class CreateBannerValidator : AbstractValidator<CreateBannerDTO>
    {
        public CreateBannerValidator()
        {
            Include(new IBannerDTOValidator());
        }
    }
}
