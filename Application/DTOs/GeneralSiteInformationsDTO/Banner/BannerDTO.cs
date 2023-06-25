﻿using Application.DTOs.Common;
using System;

namespace Application.DTOs.GeneralSiteInformationsDTO.Banner
{
    public class BannerDTO : BaseEntityDTO, IBannerDTO
    {
        public string BannerImage { get; set; }
        public string Link { get; set; }
    }
}
