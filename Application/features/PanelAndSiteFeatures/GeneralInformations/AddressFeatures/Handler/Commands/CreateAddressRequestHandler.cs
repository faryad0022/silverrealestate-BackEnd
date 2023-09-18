using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.Address;
using Application.DTOs.GeneralSiteInformationsDTO.Address.Validator;
using Application.features.PanelAndSiteFeatures.GeneralInformations.AddressFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.PanelAndSiteFeatures.GeneralInformations.AddressFeatures.Handler.Commands
{
    public class CreateAddressRequestHandler : IRequestHandler<CreateAddressRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateAddressRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateAddressRequest request, CancellationToken cancellationToken)
        {
            var toAddressDTO = _mapper.Map<AddressDTO>(request.createAddressDTO);
            #region Validation
            var validator = new CreateAddressValidator();
            var validationResult = await validator.ValidateAsync(request.createAddressDTO);
            if (!validationResult.IsValid)
                return ResponseResultDTO.SetResult(
                                toAddressDTO,
                                StatusMessage.ValidationError,
                                validationResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var address = _mapper.Map<Address>(request.createAddressDTO);
            await _unitofWork.AddressRepository.AddEntityAsync(address);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(toAddressDTO, StatusMessage.Success, null);
        }
    }
}
