using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    public class CityController : BaseApiController<City>
    {
        public CityController(IBaseService baseService) : base(baseService)
        {
        }
    }
}
