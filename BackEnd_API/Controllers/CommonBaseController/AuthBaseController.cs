using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_API.Controllers.CommonBaseController
{
    [Route("auth")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Auth")]
    [Produces("application/json")]
    public class AuthBaseController : ControllerBase
    {
    }
}
