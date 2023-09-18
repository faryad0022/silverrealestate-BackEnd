﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Commands
{
    public class UpdateBannerLinkRequest : IRequest<ResponseResultDTO>
    {
        public UpdateBannerLinkDTO updateBannerLinkDTO { get; set; }
    }
}