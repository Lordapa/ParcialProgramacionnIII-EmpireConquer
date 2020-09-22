using MiguelBeneditProgramación3_Core.Entities;
using MiguelBeneditProgramación3_Core.Interfaces.Services;

namespace MiguelBeneditProgramación3_WebApplication.V1.Controllers
{
    public class GameController : BaseApiController<Game>
    {
        public GameController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
