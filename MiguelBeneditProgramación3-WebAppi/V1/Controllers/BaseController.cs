using Microsoft.AspNetCore.Mvc;

namespace MiguelBeneditProgramación3_WebApplication.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
    }
}
