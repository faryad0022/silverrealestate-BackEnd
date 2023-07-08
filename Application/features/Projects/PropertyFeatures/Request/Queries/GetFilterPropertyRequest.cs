using Application.Const.Response;
using Application.DTOs.Project.PropertDTOs;
using MediatR;

namespace Application.features.Projects.PropertyFeatures.Request.Queries
{
    public class GetFilterPropertyRequest : IRequest<ResponseResultDTO>
    {
        public FilterPropertyDTO filterDTO { get; set; }
    }
}
