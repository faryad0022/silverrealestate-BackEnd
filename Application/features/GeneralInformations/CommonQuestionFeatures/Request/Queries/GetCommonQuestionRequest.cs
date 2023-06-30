﻿using Application.Const.Response;
using MediatR;

namespace Application.features.GeneralInformations.CommonQuestionFeatures.Request.Queries
{
    public class GetCommonQuestionRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
