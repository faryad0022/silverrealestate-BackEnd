using Microsoft.AspNetCore.Mvc;

namespace BackEnd_API.Controllers.CommonBaseController
{
    [Route("admin")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Admin")]
    [Produces("application/json")]
    public class AdminBaseController : ControllerBase
    {
    }
}
