﻿using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.CityFeatures.Request.Queries
{
    public class GetCityWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public long cityId { get; set; }
    }
}