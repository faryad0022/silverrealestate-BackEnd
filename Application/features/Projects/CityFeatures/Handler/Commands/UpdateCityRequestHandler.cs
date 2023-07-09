using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.City;
using Application.DTOs.Project.City.Validators;
using Application.features.Projects.CityFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CityFeatures.Handler.Commands
{
    public class UpdateCityRequestHandler : IRequestHandler<UpdateCityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateCityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdateCityRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validatore = new UpdateCityDTOValidator(_unitofWork);
            var validatorResult = await validatore.ValidateAsync(request.updateCityDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.updateCityDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(a => a.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<City>(request.updateCityDTO);
            _unitofWork.CityRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<CityDTO>(toUpdate), StatusMessage.Success, null);
        }
    }
}
