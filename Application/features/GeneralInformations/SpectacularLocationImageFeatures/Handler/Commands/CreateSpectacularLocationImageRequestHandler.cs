using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages;
using Application.DTOs.GeneralSiteInformationsDTO.SpectacularLocationImages.Validatores;
using Application.features.GeneralInformations.SpectacularLocationImageFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.SpectacularLocationImageFeatures.Handler.Commands
{
    public class CreateSpectacularLocationImageRequestHandler : IRequestHandler<CreateSpectacularLocationImageRequest, ReturnData<SpectacularLocationImagesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateSpectacularLocationImageRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<SpectacularLocationImagesDTO>> Handle(CreateSpectacularLocationImageRequest request, CancellationToken cancellationToken)
        {
            var toCreate = _mapper.Map<SpectacularLocationImages>(request.createSpectacularLocationImagesDTO);
            #region Validator
            var validator = new CreateSpectacularLocationImagesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createSpectacularLocationImagesDTO);
            if (!validatorResult.IsValid)
                return FillRetuenData<SpectacularLocationImagesDTO>.FillByEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var created = await _unitofWork.SpectacularLocationImageRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<SpectacularLocationImagesDTO>.FillByEntity(
                _mapper.Map<SpectacularLocationImagesDTO>(created),
                ResponseStatus.Success,
                null
                );
        }
    }
}
