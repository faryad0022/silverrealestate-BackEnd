﻿using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyFeatures.Request.Queries
{
    public class GetPropertyListWithDetailsRequest : IRequest<ResponseResultDTO>
    {
        public bool PropertyStatus { get; set; } 
        public bool Selected { get; set; } 
    }
}
