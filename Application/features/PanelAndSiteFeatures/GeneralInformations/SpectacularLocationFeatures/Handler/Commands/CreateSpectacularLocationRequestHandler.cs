using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocations.Validators;
using Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationFeatures.Handler.Commands
{
    public class CreateSpectacularLocationRequestHandler : IRequestHandler<CreateSpectacularLocationRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateSpectacularLocationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateSpectacularLocationRequest request, CancellationToken cancellationToken)
        {
            var createSpectacularLocation = _mapper.Map<Spectacularlocation>(request.createSpectacularLocationDTO);
            #region Validation
            var validator = new CreateSpectacularLocationDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createSpectacularLocationDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var createdSpectacularLocation = await _unitofWork.SpectacularlocationRepository.AddEntityAsync(createSpectacularLocation);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(
                    _mapper.Map<SpectacularLocationDTO>(createdSpectacularLocation),
                    StatusMessage.Success,
                    null);
        }
    }
}
