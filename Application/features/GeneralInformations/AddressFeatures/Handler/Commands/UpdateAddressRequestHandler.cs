using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.DTOs.GeneralSiteInformationsDTO.Address.Validator;
using Application.features.GeneralInformations.AddressFeatures.Request.Commands;
using Application.Reaspose;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.AddressFeatures.Handler.Commands
{
    public class UpdateAddressRequestHandler : IRequestHandler<UpdateAddressRequest, ReturnData<AddressDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateAddressRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<AddressDTO>> Handle(UpdateAddressRequest request, CancellationToken cancellationToken)
        {
            var address = await _unitofWork.AddressRepository.GetEntityAsync(request.updateAddressDTO.Id);
            var toAddressDTO = _mapper.Map<AddressDTO>(request.updateAddressDTO);
            if (address is null)
                return FillRetuenData<AddressDTO>.FillByEntity(toAddressDTO, ResponseStatus.NotFound, null);
            #region Validation
            var validator = new UpdateAddressValidator();
            var validatorResult = await validator.ValidateAsync(request.updateAddressDTO);
            if (!validatorResult.IsValid)
                return FillRetuenData<AddressDTO>.FillByEntity(
                    toAddressDTO,
                    ResponseStatus.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<Address>(request.updateAddressDTO);
            _unitofWork.AddressRepository.UpdateEntityAsync(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<AddressDTO>.FillByEntity(toAddressDTO, ResponseStatus.Success, null);
        }
    }
}
