using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Facility;
using Application.DTOs.Project.Facility.Validators;
using Application.features.Projects.FacilityFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.FacilityFeatures.Handler.Commands
{
    public class CreateFacilityRequestHandler : IRequestHandler<CreateFacilityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateFacilityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreateFacilityRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateFacilityDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.createFacilityDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.createFacilityDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion

            var toCreate = _mapper.Map<Facility>(request.createFacilityDTO);
            toCreate = await _unitofWork.FacilityRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<FacilityDTO>(toCreate), StatusMessage.Success, null);
        }
    }
}
