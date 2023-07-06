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
    public class CreateCityRequestHandler : IRequestHandler<CreateCityRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateCityRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreateCityRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateCityDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.createCityDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.createCityDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion

            var toCreate = _mapper.Map<City>(request.createCityDTO);
            toCreate = await _unitofWork.CityRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<CityDTO>(toCreate), StatusMessage.Success, null);
        }
    }
}
