﻿using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Queries
{
    public class GetConstructorInformationRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
