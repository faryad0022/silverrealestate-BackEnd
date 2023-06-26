using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands
{
    public class ChangeCommonQuestionSelectedStatusRequestHandler : IRequestHandler<ChangeCommonQuestionSelectedStatusRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeCommonQuestionSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(ChangeCommonQuestionSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var common = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.Id);
            if (common is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.CommonQuestionRepository.ChangeSelectedStatusAsync(common);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(_mapper.Map<CommonQuestionDTO>(common), StatusMessage.Success, null);
        }
    }
}
