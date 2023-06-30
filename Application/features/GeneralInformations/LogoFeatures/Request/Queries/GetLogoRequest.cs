﻿using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.LogoFeatures.Request.Queries
{
    public class GetLogoRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
