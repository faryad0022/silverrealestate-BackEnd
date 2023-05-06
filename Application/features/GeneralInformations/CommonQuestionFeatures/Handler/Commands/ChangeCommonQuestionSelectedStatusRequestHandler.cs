using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.Reaspose;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands
{
    public class ChangeCommonQuestionSelectedStatusRequestHandler : IRequestHandler<ChangeCommonQuestionSelectedStatusRequest, ReturnData<CommonQuestionDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeCommonQuestionSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<CommonQuestionDTO>> Handle(ChangeCommonQuestionSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var common = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.Id);
            if (common is null)
                return FillRetuenData<CommonQuestionDTO>.FillByEntity(null, ResponseStatus.NotFound, null);
            _unitofWork.CommonQuestionRepository.ChangeSelectedStatusAsync(common);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<CommonQuestionDTO>.FillByEntity(_mapper.Map<CommonQuestionDTO>(common), ResponseStatus.Success, null);
        }
    }
}
