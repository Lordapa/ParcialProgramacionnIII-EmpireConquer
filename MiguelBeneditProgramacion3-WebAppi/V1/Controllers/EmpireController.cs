using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    public class EmpireController : BaseApiController<Empire>
    {
        public EmpireController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
