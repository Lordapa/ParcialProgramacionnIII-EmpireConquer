using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    public class UserController : BaseApiController<User>
    {
        public UserController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
