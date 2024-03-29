﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Banner;
using Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.BannerFeatures.Handler.Queries
{
    public class GetBannerRequestHandler : IRequestHandler<GetBannerRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetBannerRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetBannerRequest request, CancellationToken cancellationToken)
        {
            var banner = await _unitofWork.BannerRepository.GetEntityAsync(request.Id);
            if (banner is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var bannerDTO = _mapper.Map<BannerDTO>(banner);
            return ResponseResultDTO.SetResult(bannerDTO, StatusMessage.Success, null);
        }
    }
}
