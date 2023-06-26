﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Queries
{
    public class GetCommonQuestionListRequestHandler : IRequestHandler<GetCommonQuestionListRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCommonQuestionListRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetCommonQuestionListRequest request, CancellationToken cancellationToken)
        {
            var CommonQuestionList = await _unitofWork.CommonQuestionRepository.GetAllAsync();
            if (CommonQuestionList is null || CommonQuestionList.Count == 0)
                return ResponseResult.SetResult(null, StatusMessage.NoContent, null);
            if (request.justShowSelected)
            {
                var selectedCommonQuestion = CommonQuestionList.Where(x => x.IsSelected).ToList();
                var SelectedCommonQuestionDTo = _mapper.Map<List<CommonQuestionDTO>>(selectedCommonQuestion);
                return ResponseResult.SetResult(SelectedCommonQuestionDTo, StatusMessage.Success, null);
            }
            var commonQuestionListDTO = _mapper.Map<List<CommonQuestionDTO>>(CommonQuestionList);
            return ResponseResult.SetResult(commonQuestionListDTO, StatusMessage.Success, null);
        }
    }
}
