using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages.Validatores;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Commands
{
    public class CreateSpectacularLocationImageRequestHandler : IRequestHandler<CreateSpectacularLocationImageRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateSpectacularLocationImageRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateSpectacularLocationImageRequest request, CancellationToken cancellationToken)
        {
            var toCreate = _mapper.Map<SpectacularLocationImages>(request.createSpectacularLocationImagesDTO);
            #region Validator
            var validator = new CreateSpectacularLocationImagesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createSpectacularLocationImagesDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var created = await _unitofWork.SpectacularLocationImageRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(
                _mapper.Map<SpectacularLocationImagesDTO>(created),
                StatusMessage.Success,
                null
                );
        }
    }
}
