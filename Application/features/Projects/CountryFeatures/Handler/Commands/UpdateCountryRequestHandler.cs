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
    public class UpdateCountryRequestHandler : IRequestHandler<UpdateCountryRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdateCountryRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdateCountryRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validatore = new UpdateCountryDTOValidator(_unitofWork);
            var validatorResult = await validatore.ValidateAsync(request.updateCountryDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.updateCountryDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(a => a.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<Country>(request.updateCountryDTO);
            _unitofWork.CountryRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<CountryDTO>(toUpdate), StatusMessage.Success, null);
        }
    }
}
