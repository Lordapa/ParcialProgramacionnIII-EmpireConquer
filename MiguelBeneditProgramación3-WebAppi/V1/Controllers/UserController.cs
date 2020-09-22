using MiguelBeneditProgramación3_Core.Entities;
using MiguelBeneditProgramación3_Core.Interfaces.Services;

namespace MiguelBeneditProgramación3_WebApplication.V1.Controllers
{
    public class UserController : BaseApiController<User>
    {
        public UserController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
