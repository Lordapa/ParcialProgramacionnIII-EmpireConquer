using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// Heroe api controller
    /// </summary>
    public class HeroeController : BaseApiController<Heroe>
    {
        public HeroeController(IBaseService<Heroe> baseService) : base(baseService)
        {
        }
    }
}
