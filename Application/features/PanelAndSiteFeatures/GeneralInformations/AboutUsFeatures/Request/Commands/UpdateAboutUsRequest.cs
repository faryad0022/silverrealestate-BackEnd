﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.AboutUsFeatures.Request.Commands
{
    public class UpdateAboutUsRequest : IRequest<ResponseResultDTO>
    {
        public UpdateAboutUsDTO updateAboutUsDTO { get; set; }
    }
}