using Application.DTOs.GeneralSiteInformationsDTO.AboutUs;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Commands;
using Application.features.GeneralInformations.AboutUsFeatures.Request.Queries;
using Application.Reaspose;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackEnd_API.Controllers
{

    public class AboutUsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutUsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("get-aboutus-list")]
        public async Task<ActionResult<ReturnData<AboutUsDTO>>> GetAboutUsListAsync()
            => await _mediator.Send(new GetAboutUsListRequest());


        [HttpGet("get-aboutus")]
        public async Task<ActionResult<ReturnData<AboutUsDTO>>> GetAboutUsListAsync([FromQuery] long Id)
            => await _mediator.Send(new GetAboutUsRequest { Id = Id });


        [HttpPost("add-aboutus")]
        public async Task<ActionResult<ReturnData<CreateAboutUsDTO>>> AddAboutusAsync([FromBody] CreateAboutUsDTO aboutUsDTO)
            => await _mediator.Send(new CreateAboutUsRequest { createAboutUsDTO = aboutUsDTO });


        [HttpPut("update-aboutus")]
        public async Task<ActionResult<ReturnData<UpdateAboutUsDTO>>> UpdateAboutusAsync([FromQuery] UpdateAboutUsDTO aboutUsDTO)
            => await _mediator.Send(new UpdateAboutUsRequest { updateAboutUsDTO = aboutUsDTO });
    }
}
