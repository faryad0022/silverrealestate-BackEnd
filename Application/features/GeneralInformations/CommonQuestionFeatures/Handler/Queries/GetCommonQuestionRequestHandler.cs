using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Queries
{
    public class GetCommonQuestionRequestHandler : IRequestHandler<GetCommonQuestionRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCommonQuestionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(GetCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            var commonQuestion = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.Id);
            if (commonQuestion is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            var commonQuestionDTO = _mapper.Map<CommonQuestionDTO>(commonQuestion);
            return ResponseResult.SetResult(commonQuestionDTO, StatusMessage.Success, null);

        }
    }
}
