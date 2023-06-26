using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Queries
{
    public class GetConstructorInformationListRequest : IRequest<ResponseResult>
    {
        public bool justShowSelected { get; set; } = false;
    }
}
