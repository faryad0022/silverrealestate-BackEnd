using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.Project.PropertyVideos;
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
    public class CreatePropertyVideoRequestHandler : IRequestHandler<CreatePropertyVideoRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public CreatePropertyVideoRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }

        public async Task<ResponseResultDTO> Handle(CreatePropertyVideoRequest request, CancellationToken cancellationToken)
        {
            #region Validation
            var validator = new CreatePropertyVideoDTOValidator(_unitofWork);
            var validatorResult = await validator.ValidateAsync(request.createPropertyVideoDTO);
            if (!validatorResult.IsValid)
                return ResponseResultDTO.SetResult(request.createPropertyVideoDTO, StatusMessage.ValidationError, validatorResult.Errors.Select(q => q.ErrorMessage).ToList());
            #endregion
            var toCreate = _mapper.Map<PropertyVideo>(request.createPropertyVideoDTO);
            toCreate = await _unitofWork.PropertyVideoRepository.AddEntityAsync(toCreate);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(_mapper.Map<PropertyVideoDTO>(toCreate), StatusMessage.Success, null);
        }
    }
}
