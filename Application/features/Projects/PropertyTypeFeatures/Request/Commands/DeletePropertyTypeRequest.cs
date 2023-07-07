using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyTypeFeatures.Request.Commands
{
    public class DeletePropertyTypeRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
