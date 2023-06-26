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
    public class CreateConstructorInformationRequestHandler : IRequestHandler<CreateConstructorInformationRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateConstructorInformationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(CreateConstructorInformationRequest request, CancellationToken cancellationToken)
        {
            #region validation
            var validator = new CreateConstructorInformationValidator();
            var validationResult = await validator.ValidateAsync(request.createConstructorInformationDTO);
            if (!validationResult.IsValid)
                return ResponseResult.SetResult(
                                null,
                                StatusMessage.ValidationError,
                                validationResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var constructor = _mapper.Map<ConstructorInformation>(request.createConstructorInformationDTO);
            await _unitofWork.ConstructorInfromationRepository.AddEntityAsync(constructor);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(request.createConstructorInformationDTO, StatusMessage.Success, null);
        }
    }
}
