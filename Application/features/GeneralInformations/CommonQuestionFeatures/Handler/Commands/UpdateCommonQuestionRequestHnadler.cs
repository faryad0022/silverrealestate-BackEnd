using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions.Validators;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands
{
    public class UpdateCommonQuestionRequestHnadler : IRequestHandler<UpdateCommonQuestionRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateCommonQuestionRequestHnadler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(UpdateCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            var commonQuestion = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.updateCommonQuestionDTO.Id);
            if (commonQuestion is null)
                return ResponseResultDTO.SetResult(request.updateCommonQuestionDTO, StatusMessage.NotFound, null);
            #region Validation
            var validator = new UpdateCommonQuestionValidator();
            var validatorResult = await validator.ValidateAsync(request.updateCommonQuestionDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    request.updateCommonQuestionDTO,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<CommonQuestion>(request.updateCommonQuestionDTO);
            _unitofWork.CommonQuestionRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(request.updateCommonQuestionDTO, StatusMessage.Success, null);
        }
    }
}
