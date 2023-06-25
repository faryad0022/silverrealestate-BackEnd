using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions;
using Application.DTOs.GeneralSiteInformationsDTO.CommonQuestions.Validators;
using Application.features.GeneralInformations.CommonQuestionFeatures.Request.Command;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Handler.Commands
{
    public class CreateCommonQuestionRequestHandler : IRequestHandler<CreateCommonQuestionRequest, ReturnData<CreateCommonQuestionDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateCommonQuestionRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<CreateCommonQuestionDTO>> Handle(CreateCommonQuestionRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateCommonQuestionValidator();
            var validatorResult = await validator.ValidateAsync(request.createCommonQuestionDTO);
            if (!validatorResult.IsValid)
                return SetReturnData<CreateCommonQuestionDTO>.SetTEntity(null, ResponseStatus.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var commonDTO = _mapper.Map<CommonQuestion>(request.createCommonQuestionDTO);
            await _unitofWork.CommonQuestionRepository.AddEntityAsync(commonDTO);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<CreateCommonQuestionDTO>.SetTEntity(request.createCommonQuestionDTO, ResponseStatus.Success, null);

        }
    }
}
