﻿using Application.Const.Response;
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
    public class UpdateSpectacularLocationImageRequestHandler : IRequestHandler<UpdateSpectacularLocationImageRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateSpectacularLocationImageRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(UpdateSpectacularLocationImageRequest request, CancellationToken cancellationToken)
        {
            var spectaculraImage = await _unitofWork.SpectacularLocationImageRepository.GetEntityAsync(request.updateSpectacularLocationImagesDTO.Id);
            if (spectaculraImage is null)
                return ResponseResult.SetResult(
                    null,
                    StatusMessage.NotFound,
                    null
                    );
            #region Validator
            var validator = new UpdateSpectacularLocationImagesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.updateSpectacularLocationImagesDTO);
            if (!validatorResult.IsValid)
                return ResponseResult.SetResult(
                    _mapper.Map<SpectacularLocationImagesDTO>(request.updateSpectacularLocationImagesDTO),
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList()
                    );
            #endregion

            var toUpdate = _mapper.Map<SpectacularLocationImages>(request.updateSpectacularLocationImagesDTO);
            _unitofWork.SpectacularLocationImageRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();

            return ResponseResult.SetResult(
                _mapper.Map<SpectacularLocationImagesDTO>(request.updateSpectacularLocationImagesDTO),
                StatusMessage.Success,
                null
                );

        }
    }
}
