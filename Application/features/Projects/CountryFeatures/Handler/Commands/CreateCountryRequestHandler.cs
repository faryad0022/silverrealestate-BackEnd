using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.Country;
using Application.DTOs.Project.Country.Validators;
using Application.features.Projects.CountryFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.CountryFeatures.Handler.Commands
{
    public class CreateCountryRequestHandler : IRequestHandler<CreateCountryRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreateCountryRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreateCountryRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreateCountryDTOValidator();
            var validatorResult = await validator.ValidateAsync(request.createCountryDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.createCountryDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion

            var toCreate = _mapper.Map<Country>(request.createCountryDTO);
            toCreate = await _unitofWork.CountryRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<CountryDTO>(toCreate), StatusMessage.Success, null);
        }
    }
}
