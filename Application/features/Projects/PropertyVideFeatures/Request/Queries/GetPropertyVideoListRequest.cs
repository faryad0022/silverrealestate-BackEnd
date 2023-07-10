﻿using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyVideFeatures.Request.Queries
{
    public class GetPropertyVideoListRequest : IRequest<ResponseResultDTO>
    {
        public long PropertyId { get; set; }
        public bool Selected { get; set; }
    }
}