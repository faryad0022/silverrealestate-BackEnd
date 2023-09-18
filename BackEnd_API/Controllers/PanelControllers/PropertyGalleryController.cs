using Application.Const.Response;
using Application.DTOs.Project.PropertyGalleries;
using Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Commands;
using Application.features.PanelAndSiteFeatures.Projects.PropertyGalleryFeatures.Request.Qureries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.PanelControllers
{
    public class PropertyGalleryController : AdminBaseController
    {
        private readonly IMediator _mediator;

        public PropertyGalleryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyGallery_GetAll, Name = "GetAllPropertyGallerys")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyGallerys([FromQuery] long propertyId)
            => await _mediator.Send(new GetPropertyGalleryListRequest() { PropertyId = propertyId });


        [HttpGet(ApiRouteV1.PropertyGallery_Get, Name = "GetPropertyGallery")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyGallery([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyGalleryRequest() { Id = Id });

        [HttpPost(ApiRouteV1.PropertyGallery_Add, Name = "AddPropertyGallery")]
        public async Task<ActionResult<ResponseResultDTO>> AddPropertyGallery([FromBody] CreatePropertyGalleryDTO createPropertyGalleryDTO)
            => await _mediator.Send(new CreatePropertyGalleryRequest() { createPropertyGalleryDTO = createPropertyGalleryDTO });


        [HttpPut(ApiRouteV1.PropertyGallery_Delete, Name = "DeletePropertyGallery")]
        public async Task<ActionResult<ResponseResultDTO>> DeletePropertyGallery([FromBody] long id)
            => await _mediator.Send(new DeletePropertyGalleryRequest() { Id = id });
    }
}
