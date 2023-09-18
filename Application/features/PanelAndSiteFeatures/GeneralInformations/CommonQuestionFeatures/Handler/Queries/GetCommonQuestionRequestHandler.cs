using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.PanelAndSiteFeatures.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.CommonQuestionFeatures.Handler.Queries
{
    public class GetCommonQuestionRequestHandler : IRequestHandler<GetCommonQuestionRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCommonQuestionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(GetCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            var commonQuestion = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.Id);
            if (commonQuestion is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var commonQuestionDTO = _mapper.Map<CommonQuestionDTO>(commonQuestion);
            return ResponseResultDTO.SetResult(commonQuestionDTO, StatusMessage.Success, null);

        }
    }
}
