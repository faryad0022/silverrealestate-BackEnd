using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess.Validators;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Commands
{
    public class UpdateRealEstateServicesRequestHandler : IRequestHandler<UpdateRealEstateServicesRequest, ReturnData<UpdateRealEstateServicesDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateRealEstateServicesRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<UpdateRealEstateServicesDTO>> Handle(UpdateRealEstateServicesRequest request, CancellationToken cancellationToken)
        {
            var realEstateService = await _unitofWork.RealEstateServicesRepository.GetEntityAsync(request.updateRealEstateServicesDTO.Id);
            if (realEstateService is null)
                return SetReturnData<UpdateRealEstateServicesDTO>.SetTEntity(null, ResponseStatus.NotFound, null);
            #region Validation
            var validator = new UpdateRealEstateServicesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.updateRealEstateServicesDTO);
            if (!validatorResult.IsValid)
                return SetReturnData<UpdateRealEstateServicesDTO>.SetTEntity(
                    null,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<RealEstateServices>(request.updateRealEstateServicesDTO);
            _unitofWork.RealEstateServicesRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return SetReturnData<UpdateRealEstateServicesDTO>.SetTEntity(request.updateRealEstateServicesDTO, ResponseStatus.Success, null);

        }
    }
}
