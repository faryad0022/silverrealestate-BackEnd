using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations.Validators;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.ConstructorInformations.Handler.Commands
{
    public class UpdateConstructorInformationRequestHandler : IRequestHandler<UpdateConstructorInformationRequest, ReturnData<UpdateConstructorInformationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateConstructorInformationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<UpdateConstructorInformationDTO>> Handle(UpdateConstructorInformationRequest request, CancellationToken cancellationToken)
        {
            var constructor = await _unitofWork.ConstructorInfromationRepository.GetEntityAsync(request.updateConstructorInformationDTO.Id);
            if (constructor is null)
                return SetReturnData<UpdateConstructorInformationDTO>.SetTEntity(request.updateConstructorInformationDTO, ResponseStatus.NotFound, null);
            #region Validation
            var validator = new UpdateConstructorInformationValidator();
            var validatorResult = await validator.ValidateAsync(request.updateConstructorInformationDTO);
            if (!validatorResult.IsValid)
                return SetReturnData<UpdateConstructorInformationDTO>.SetTEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<ConstructorInformation>(request.updateConstructorInformationDTO);
            _unitofWork.ConstructorInfromationRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<UpdateConstructorInformationDTO>.SetTEntity(request.updateConstructorInformationDTO, ResponseStatus.Success, null);
        }
    }
}
