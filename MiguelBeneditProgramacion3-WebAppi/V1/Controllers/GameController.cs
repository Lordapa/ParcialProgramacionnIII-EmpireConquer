using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// Game api controller
    /// </summary>
    public class GameController : BaseApiController<Game>
    {
        public GameController(IBaseService<Game> baseService) : base(baseService)
        {
        }
    }
}
