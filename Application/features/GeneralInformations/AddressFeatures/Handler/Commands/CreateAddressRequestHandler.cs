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
    public class CreateAddressRequestHandler : IRequestHandler<CreateAddressRequest, ReturnData<AddressDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateAddressRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ReturnData<AddressDTO>> Handle(CreateAddressRequest request, CancellationToken cancellationToken)
        {
            var toAddressDTO = _mapper.Map<AddressDTO>(request.createAddressDTO);
            #region Validation
            var validator = new CreateAddressValidator();
            var validationResult = await validator.ValidateAsync(request.createAddressDTO);
            if (!validationResult.IsValid)
                return FillRetuenData<AddressDTO>.FillByEntity(
                                toAddressDTO,
                                ResponseStatus.ValidationError,
                                validationResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var address = _mapper.Map<Address>(request.createAddressDTO);
            await _unitofWork.AddressRepository.AddEntityAsync(address);
            await _unitofWork.SaveChangesAsync();
            return FillRetuenData<AddressDTO>.FillByEntity(toAddressDTO, ResponseStatus.Success, null);
        }
    }
}
