using Application.Const.Response;
using MediatR;

namespace Application.features.Projects.PropertyTypeFeatures.Request.Queries
{
    public class GetPropertyTypeListRequest : IRequest<ResponseResultDTO>
    {
        public bool justSelected { get; set; }
    }
}
