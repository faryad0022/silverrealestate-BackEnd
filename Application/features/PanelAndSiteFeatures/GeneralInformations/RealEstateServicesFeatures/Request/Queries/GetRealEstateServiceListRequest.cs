﻿using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.RealEstateServicesFeatures.Request.Queries
{
    public class GetRealEstateServiceListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;
    }
}