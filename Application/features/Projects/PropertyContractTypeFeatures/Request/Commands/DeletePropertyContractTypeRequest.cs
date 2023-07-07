using Application.Const.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.features.Projects.PropertyContractTypeFeatures.Request.Commands
{
    public class DeletePropertyContractTypeRequest:IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
