using MiguelBeneditProgramación3_Core.Entities;
using MiguelBeneditProgramación3_Core.Interfaces.Services;

namespace MiguelBeneditProgramación3_WebApplication.V1.Controllers
{
    public class MapController : BaseApiController<Map>
    {
        public MapController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
