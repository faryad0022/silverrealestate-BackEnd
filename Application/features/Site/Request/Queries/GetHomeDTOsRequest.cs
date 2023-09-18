using Application.Const.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.features.Site.Request.Queries
{
    public class GetHomeDTOsRequest:IRequest<ResponseResultDTO>
    {
    }
}
