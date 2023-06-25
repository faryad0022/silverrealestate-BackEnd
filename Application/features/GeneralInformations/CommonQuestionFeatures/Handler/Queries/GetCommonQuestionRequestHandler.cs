using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Queries
{
    public class GetCommonQuestionRequestHandler : IRequestHandler<GetCommonQuestionRequest, ReturnData<CommonQuestionDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public GetCommonQuestionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<CommonQuestionDTO>> Handle(GetCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            var commonQuestion = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.Id);
            if (commonQuestion is null)
                return SetReturnData<CommonQuestionDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            var commonQuestionDTO = _mapper.Map<CommonQuestionDTO>(commonQuestion);
            return SetReturnData<CommonQuestionDTO>.SetTEntity(commonQuestionDTO, ResponseStatus.Success, null);

        }
    }
}
