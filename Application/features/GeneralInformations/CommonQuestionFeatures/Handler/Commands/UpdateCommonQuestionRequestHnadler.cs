using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
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
    public class UpdateCommonQuestionRequestHnadler : IRequestHandler<UpdateCommonQuestionRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateCommonQuestionRequestHnadler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(UpdateCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            var commonQuestion = await _unitofWork.CommonQuestionRepository.GetEntityAsync(request.updateCommonQuestionDTO.Id);
            if (commonQuestion is null)
                return ResponseResult.SetResult(request.updateCommonQuestionDTO, StatusMessage.NotFound, null);
            #region Validation
            var validator = new UpdateCommonQuestionValidator();
            var validatorResult = await validator.ValidateAsync(request.updateCommonQuestionDTO);
            if (!validatorResult.IsValid)
                return ResponseResult.SetResult(
                    request.updateCommonQuestionDTO,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<CommonQuestion>(request.updateCommonQuestionDTO);
            _unitofWork.CommonQuestionRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(request.updateCommonQuestionDTO, StatusMessage.Success, null);
        }
    }
}
