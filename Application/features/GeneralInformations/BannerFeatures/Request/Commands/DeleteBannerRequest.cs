﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.GeneralInformations.BannerFeatures.Request.Commands
{
    public class DeleteBannerRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}