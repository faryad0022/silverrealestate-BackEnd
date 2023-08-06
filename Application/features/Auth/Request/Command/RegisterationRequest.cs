﻿using Application.Const.Response;
using Application.Models.Identity;
using MediatR;

namespace Application.features.Auth.Request.Command
{
    public class RegisterationRequest : IRequest<ResponseResultDTO>
    {
        public RegisterRequest registerRequest { get; set; }
    }
}
