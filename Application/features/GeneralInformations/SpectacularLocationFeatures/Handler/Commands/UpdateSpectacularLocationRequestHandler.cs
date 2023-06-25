using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations.Validators;
using Application.features.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationFeatures.Handler.Commands
{
    public class UpdateSpectacularLocationRequestHandler : IRequestHandler<UpdateSpectacularLocationRequest, ReturnData<SpectacularLocationDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateSpectacularLocationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<SpectacularLocationDTO>> Handle(UpdateSpectacularLocationRequest request, CancellationToken cancellationToken)
        {
            var updateSpectacularLocation = await _unitofWork.SpectacularlocationRepository.GetEntityAsync(request.updateSpectacularLocationDTO.Id);
            if (updateSpectacularLocation is null)
                return SetReturnData<SpectacularLocationDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            #region Validation
            var validator = new UpdateSpectacularLocationDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.updateSpectacularLocationDTO);
            if (!validatorResult.IsValid)
                return SetReturnData<SpectacularLocationDTO>.SetTEntity(
                    _mapper.Map<SpectacularLocationDTO>(request.updateSpectacularLocationDTO),
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            #endregion

            var toUpdate = _mapper.Map<Spectacularlocation>(request.updateSpectacularLocationDTO);
            _unitofWork.SpectacularlocationRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<SpectacularLocationDTO>.SetTEntity(
                _mapper.Map<SpectacularLocationDTO>(request.updateSpectacularLocationDTO),
                ResponseStatus.Success,
                null
                );
        }
    }
}
