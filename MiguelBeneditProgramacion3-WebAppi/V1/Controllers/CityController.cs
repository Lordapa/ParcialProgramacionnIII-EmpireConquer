using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// City api controller
    /// </summary>
    public class CityController : BaseApiController<City>
    {
        public CityController(IBaseService<City> baseService) : base(baseService)
        {
        }
    }
}
