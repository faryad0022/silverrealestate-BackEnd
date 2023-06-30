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
    public class DeleteCommonQuestionRequestHandler : IRequestHandler<DeleteCommonQuestionRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteCommonQuestionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            var toDelete = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.Id);
            if (toDelete is null)
                return ResponseResultDTO.SetResult(toDelete, StatusMessage.NotFound, null);
            var toDeleteDTO = _mapper.Map<CommonQuestionDTO>(toDelete);
            _unitofWork.CommonQuestionRepository.DeleteEntity(toDelete);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(toDeleteDTO, StatusMessage.Success, null);
        }
    }
}
