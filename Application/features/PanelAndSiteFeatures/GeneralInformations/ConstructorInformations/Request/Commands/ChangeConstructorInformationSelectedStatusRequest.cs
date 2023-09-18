﻿using Application.Const.Response;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class ChangeConstructorInformationSelectedStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}