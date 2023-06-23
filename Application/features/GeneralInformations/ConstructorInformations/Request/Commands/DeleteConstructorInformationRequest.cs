using Application.DTOs.GeneralSiteInformationsDTO.ConstructorInformations;
using Application.Reaspose;
using MediatR;

namespace Application.features.GeneralInformations.ConstructorInformations.Request.Commands
{
    public class DeleteConstructorInformationRequest : IRequest<ReturnData<ConstructorInformationDTO>>
    {
        public long Id { get; set; }
    }
}
