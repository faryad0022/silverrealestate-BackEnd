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
    public class CreateCommonQuestionRequestHandler : IRequestHandler<CreateCommonQuestionRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateCommonQuestionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(CreateCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateCommonQuestionValidator();
            var validatorResult = await validator.ValidateAsync(request.createCommonQuestionDTO);
            if (!validatorResult.IsValid)
                return ResponseResult.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var commonDTO = _mapper.Map<CommonQuestion>(request.createCommonQuestionDTO);
            await _unitofWork.CommonQuestionRepository.AddEntityAsync(commonDTO);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(request.createCommonQuestionDTO, StatusMessage.Success, null);

        }
    }
}
