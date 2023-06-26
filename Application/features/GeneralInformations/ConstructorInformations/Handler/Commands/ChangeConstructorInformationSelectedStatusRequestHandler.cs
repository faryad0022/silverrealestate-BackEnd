using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.ConstructorInformations.Handler.Commands
{
    public class ChangeConstructorInformationSelectedStatusRequestHandler : IRequestHandler<ChangeConstructorInformationSelectedStatusRequest, ResponseResult>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public ChangeConstructorInformationSelectedStatusRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResult> Handle(ChangeConstructorInformationSelectedStatusRequest request, CancellationToken cancellationToken)
        {
            var constructor = await _unitofWork.ConstructorInfromationRepository.GetEntityAsync(request.Id);
            if (constructor is null)
                return ResponseResult.SetResult(null, StatusMessage.NotFound, null);
            _unitofWork.ConstructorInfromationRepository.ChangeSelectedStatusAsync(constructor);
            await _unitofWork.SaveChangesAsync();
            return ResponseResult.SetResult(_mapper.Map<ConstructorInformationDTO>(constructor), StatusMessage.Success, null);
        }
    }
}
