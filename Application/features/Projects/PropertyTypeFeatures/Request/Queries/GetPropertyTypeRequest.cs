using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyTypeFeatures.Request.Queries
{
    public class GetPropertyTypeRequest : IRequest<ResponseResultDTO>
    {
        public long Id { get; set; }
    }
}
