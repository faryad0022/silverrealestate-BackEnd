using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.RealEstateServicess.Validators;
using Application.features.GeneralInformations.RealEstateServicesFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.GeneralSiteInformation;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.RealEstateServicesFeatures.Handler.Commands
{
    public class CreateRealEstateServicesRequestHandler : IRequestHandler<CreateRealEstateServicesRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateRealEstateServicesRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(CreateRealEstateServicesRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateRealEstateServicesDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createRealEstateServicesDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(
                    null,
                    StatusMessage.ValidationError,
                    validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var realEstateServices = _mapper.Map<RealEstateServices>(request.createRealEstateServicesDTO);
            await _unitofWork.RealEstateServicesRepository.AddEntityAsync(realEstateServices);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(request.createRealEstateServicesDTO, StatusMessage.Success, null);
        }
    }
}
