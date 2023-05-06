using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator
{
    public class CreateBannerValidator:AbstractValidator<CreateBannerDTO>
    {
        public CreateBannerValidator()
        {
            Include(new IBannerDTOValidator());
        }
    }
}
