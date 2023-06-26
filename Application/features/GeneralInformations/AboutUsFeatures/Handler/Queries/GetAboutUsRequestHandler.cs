﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AboutUsFeatures.Handler.Queries
{
    public class GetAboutUsRequestHandler : IRequestHandler<GetAboutUsRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetAboutUsRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResult> Handle(GetAboutUsRequest request, CancellationToken cancellationToken)
        {
            var aboutUs = await _unitofWork.AboutUsRepository.GetEntityAsync(request.Id);
            if (aboutUs is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            return ResponseResult.SetResult(_mapper.Map<AboutUsDTO>(aboutUs), StatusMessage.Success, null);
        }
    }
}
