﻿using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Request.Queries
{
    public class GetSpectacularLocationImagesWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}