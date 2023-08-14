using Application.Const.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.features.Admin.Request.Queries
{
    public class GetRolesRequest:IRequest<ResponseResultDTO>
    {
    }
}
