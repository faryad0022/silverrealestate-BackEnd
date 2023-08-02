using Application.Const.Response;
using Application.DTOs.Project.PropertyGalleries;
using Application.features.Projects.PropertyGalleryFeatures.Request.Commands;
using Application.features.Projects.PropertyGalleryFeatures.Request.Qureries;
using BackEnd_API.Const;
using BackEnd_API.Controllers.CommonBaseController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers.SiteControllers
{
    public class PropertyGalleryController : SiteBaseController
    {
        private readonly IMediator _mediator;

        public PropertyGalleryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRouteV1.PropertyGallery_GetAll, Name = "SiteGetAllPropertyGallerys")]
        public async Task<ActionResult<ResponseResultDTO>> GetAllPropertyGallerys([FromQuery] long propertyId)
            => await _mediator.Send(new GetPropertyGalleryListRequest() { PropertyId = propertyId });


        [HttpGet(ApiRouteV1.PropertyGallery_Get, Name = "SiteGetPropertyGallery")]
        public async Task<ActionResult<ResponseResultDTO>> GetPropertyGallery([FromQuery] long Id)
            => await _mediator.Send(new GetPropertyGalleryRequest() { Id = Id });

    }
}
