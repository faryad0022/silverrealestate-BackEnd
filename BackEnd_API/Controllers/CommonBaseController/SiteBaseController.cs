using Microsoft.AspNetCore.Mvc;

namespace BackEnd_API.Controllers.CommonBaseController
{
    [Route("site")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Site")]
    [Produces("application/json")]

    public class SiteBaseController : ControllerBase
    {
    }
}
