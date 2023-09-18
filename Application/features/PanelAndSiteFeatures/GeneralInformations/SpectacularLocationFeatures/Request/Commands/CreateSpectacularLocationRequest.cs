﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationFeatures.Request.Commands
{
    public class CreateSpectacularLocationRequest : IRequest<ResponseResultDTO>
    {
        public CreateSpectacularLocationDTO createSpectacularLocationDTO { get; set; }
    }
}