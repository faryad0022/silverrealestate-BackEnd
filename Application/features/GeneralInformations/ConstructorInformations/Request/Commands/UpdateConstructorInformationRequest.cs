using Application.Const.Response;
using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using MediatR;


namespace Application.features.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class UpdateConstructorInformationRequest : IRequest<ResponseResult>
    {
        public UpdateConstructorInformationDTO updateConstructorInformationDTO { get; set; }
    }
}
