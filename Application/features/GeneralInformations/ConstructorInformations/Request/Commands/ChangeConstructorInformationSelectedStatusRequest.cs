﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class ChangeConstructorInformationSelectedStatusRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
