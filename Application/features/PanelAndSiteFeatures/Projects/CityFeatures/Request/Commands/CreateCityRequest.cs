﻿using Application.Const.Response;
using Application.DTOs.Project.City;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.CityFeatures.Request.Commands
{
    public class CreateCityRequest : IRequest<ResponseResultDTO>
    {
        public CreateCityDTO createCityDTO { get; set; }
    }
}