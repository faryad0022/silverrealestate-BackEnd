using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class CreateConstructorInformationRequest : IRequest<ResponseResult>
    {
        public CreateConstructorInformationDTO createConstructorInformationDTO { get; set; }
    }
}
