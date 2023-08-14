using Application.Const.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.features.Admin.Request.Queries
{
    public class GetUserRolesRequest:IRequest<ResponseResultDTO>
    {
        public string userId { get; set; }
    }
}
