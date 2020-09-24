using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// Empire api controller
    /// </summary>
    public class EmpireController : BaseApiController<Empire>
    {
        public EmpireController(IBaseService<Empire> baseService) : base(baseService)
        {
        }
    }
}
