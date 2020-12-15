using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// User api controller
    /// </summary>
    public class UserController : BaseApiController<User>
    {
        public UserController(IUserService baseService) : base(baseService)
        {
        }
    }
}
