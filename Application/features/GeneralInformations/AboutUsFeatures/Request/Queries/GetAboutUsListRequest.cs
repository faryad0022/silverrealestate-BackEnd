﻿using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.AboutUsFeatures.Request.Queries
{
    public class GetAboutUsListRequest : IRequest<ResponseResultDTO>
    {
        public bool justShowSelected { get; set; } = false;

    }
}
