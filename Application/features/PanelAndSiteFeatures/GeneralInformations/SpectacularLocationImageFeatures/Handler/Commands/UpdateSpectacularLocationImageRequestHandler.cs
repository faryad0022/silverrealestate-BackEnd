using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages.Validatores;
using Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.SpectacularLocationImageFeatures.Handler.Commands
{
    public class UpdateSpectacularLocationImageRequestHandler : IRequestHandler<UpdateSpectacularLocationImageRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateSpectacularLocationImageRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(UpdateSpectacularLocationImageRequest request, CancellationToken cancellationToken)
        {
            var spectaculraImage = await _unitofWork.SpectacularLocationImageRepository.GetEntityAsync(request.updateSpectacularLocationImagesDTO.Id);
            if (spectaculraImage is null)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.NotFound,
                    null
                    );
            #region Validator
            var validator = new UpdateSpectacularLocationImagesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.updateSpectacularLocationImagesDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    _mapper.Map<SpectacularLocationImagesDTO>(request.updateSpectacularLocationImagesDTO),
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            #endregion

            var toUpdate = _mapper.Map<SpectacularLocationImages>(request.updateSpectacularLocationImagesDTO);
            _unitofWork.SpectacularLocationImageRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();

            return ResponseResultDTO.SetResult(
                _mapper.Map<SpectacularLocationImagesDTO>(request.updateSpectacularLocationImagesDTO),
                StatusMessage.Success,
                null
                );

        }
    }
}
