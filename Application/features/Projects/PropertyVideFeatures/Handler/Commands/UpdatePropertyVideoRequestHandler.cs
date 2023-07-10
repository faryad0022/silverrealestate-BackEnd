using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyVideos.Validatores;
using Application.features.Projects.PropertyVideFeatures.Request.Commands;
using AutoMapper;
using Domain.Entities.Project;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.Projects.PropertyVideFeatures.Handler.Commands
{
    public class UpdatePropertyVideoRequestHandler : IRequestHandler<UpdatePropertyVideoRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public UpdatePropertyVideoRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(UpdatePropertyVideoRequest request, CancellationToken cancellationToken)
        {
            #region Validator
            var validator = new UpdatePropertyVideoDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.updatePropertyVideoDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(null, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toUpdate = _mapper.Map<PropertyVideo>(request.updatePropertyVideoDTO);
            _unitofWork.PropertyVideoRepository.UpdateEntity(toUpdate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(request.updatePropertyVideoDTO, StatusMessage.Success, null);
        }
    }
}
