using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations.Validators;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.ConstructorInformations.Handler.Commands
{
    public class UpdateConstructorInformationRequestHandler : IRequestHandler<UpdateConstructorInformationRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateConstructorInformationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(UpdateConstructorInformationRequest request, CancellationToken cancellationToken)
        {
            var constructor = await _unitofWork.ConstructorInfromationRepository.GetEntityAsync(request.updateConstructorInformationDTO.Id);
            if (constructor is null)
                return ResponseResult.SetResult(request.updateConstructorInformationDTO, StatusMessage.NotFound, null);
            #region Validation
            var validator = new UpdateConstructorInformationValidator();
            var validatorResult = await validator.ValidateAsync(request.updateConstructorInformationDTO);
            if (!validatorResult.IsValid)
                return ResponseResult.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<ConstructorInformation>(request.updateConstructorInformationDTO);
            _unitofWork.ConstructorInfromationRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(request.updateConstructorInformationDTO, StatusMessage.Success, null);
        }
    }
}
