using Application.Const.Response;
using Application.DTOs.Project.PropertDTOs;
using MediatR;

namespace Application.features.PanelAndSiteFeatures.Projects.PropertyFeatures.Request.Queries
{
    public class GetFilterPropertyRequest : IRequest<ResponseResultDTO>
    {
        public FilterPropertyDTO filterDTO { get; set; }
    }
}
