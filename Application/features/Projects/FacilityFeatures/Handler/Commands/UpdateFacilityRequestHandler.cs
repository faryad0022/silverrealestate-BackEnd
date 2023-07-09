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
    public class UpdateFacilityRequestHandler : IRequestHandler<UpdateFacilityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateFacilityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdateFacilityRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validatore = new UpdateFacilityDTOValidator(_unitofWork);
            var validatorResult = await validatore.ValidateAsync(request.updateFacilityDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.updateFacilityDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(a => a.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<Facility>(request.updateFacilityDTO);
            _unitofWork.FacilityRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<FacilityDTO>(toUpdate), StatusMessage.Success, null);
        }
    }
}
