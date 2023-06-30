﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Commands
{
    public class CreateAboutUsRequest : IRequest<ResponseResultDTO>
    {
        public CreateAboutUsDTO createAboutUsDTO { get; set; }
    }

}
