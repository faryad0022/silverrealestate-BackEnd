using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyFeatures.Request.Commands
{
    public class ChangePropertyStatusRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
