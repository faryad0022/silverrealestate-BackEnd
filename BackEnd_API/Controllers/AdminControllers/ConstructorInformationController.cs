﻿using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.features.GeneralInformations.ConstructorInformations.Request.Commands;
using Application.features.GeneralInformations.ConstructorInformations.Request.Queries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.AdminControllers
{

    public class ConstructorInformationController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public ConstructorInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRouteV1.ConstructorInformation_GetAll,Name = "GetAllConstructorInformation")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllConstructorInformation()
            => await _mediator.Send(new GetConstructorInformationListRequest());

        [HttpGet(ApiRouteV1.ConstructorInformation_Get, Name = "GetConstructorInformation")]
        public async Task<ActionResult<ResponseResultDTO>> GetConstructorInformation([FromQuery] long Id)
            => await _mediator.Send(new GetConstructorInformationRequest() { Id = Id });

        [HttpPost(ApiRouteV1.ConstructorInformation_Add, Name = "AddConstructorInformation")]
        public async Task<ActionResult<ResponseResultDTO>> AddConstructorInformation([FromBody] CreateConstructorInformationDTO createConstructorInformationDTO)
            => await _mediator.Send(new CreateConstructorInformationRequest() { createConstructorInformationDTO = createConstructorInformationDTO });

        [HttpPut(ApiRouteV1.ConstructorInformation_Update, Name = "UpdateConstructorInformation")]
        public async Task<ActionResult<ResponseResultDTO>> UpdateConstructorInformation([FromQuery] UpdateConstructorInformationDTO updateConstructorInformationDTO)
            => await _mediator.Send(new UpdateConstructorInformationRequest() { updateConstructorInformationDTO = updateConstructorInformationDTO });

        [HttpPut(ApiRouteV1.ConstructorInformation_ChangeStatus, Name = "ChangeConstructorInformationStatus")]
        public async Task<ActionResult<ResponseResultDTO>> ChangeConstructorInformationStatus([FromQuery] long Id)
            => await _mediator.Send(new ChangeConstructorInformationSelectedStatusRequest() { Id = Id });
    }
}
