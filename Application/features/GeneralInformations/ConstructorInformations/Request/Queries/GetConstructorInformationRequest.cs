using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Queries
{
    public class GetConstructorInformationRequest : IRequest<ResponseResult>
    {
        public long Id { get; set; }
    }
}
