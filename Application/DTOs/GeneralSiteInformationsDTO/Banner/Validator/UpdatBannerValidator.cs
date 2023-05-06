using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner.Validator
{
    public class UpdatBannerValidator:AbstractValidator<IBannerDTO>
    {
        public UpdatBannerValidator()
        {
            Include(new IBannerDTOValidator());

        }
    }
}
