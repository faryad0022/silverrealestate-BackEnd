﻿using Application.Const.Response;
using Application.Contract.Persistence;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.features.GeneralInformations.ConstructorInformations.Handler.Commands
{
    public class DeleteConstructorInformationRequestHandler : IRequestHandler<DeleteConstructorInformationRequest, ResponseResultDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitofWork _unitofWork;

        public DeleteConstructorInformationRequestHandler(IMapper mapper, IUnitofWork unitofWork)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task<ResponseResultDTO> Handle(DeleteConstructorInformationRequest request, CancellationToken cancellationToken)
        {
            var constructor = await _unitofWork.ConstructorInfromationRepository.GetEntityAsync(request.Id);
            if (constructor is null)
                return ResponseResultDTO.SetResult(null, StatusMessage.NotFound, null);
            var constructorDTO = _mapper.Map<ConstructorInformationDTO>(constructor);
            _unitofWork.ConstructorInfromationRepository.DeleteEntity(constructor);
            await _unitofWork.SaveChangesAsync();
            return ResponseResultDTO.SetResult(constructorDTO, StatusMessage.Success, null);
        }
    }
}
