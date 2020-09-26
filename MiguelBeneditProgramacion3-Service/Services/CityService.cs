using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class CityService : BaseService<City>
    {
        public CityService(IRepository<City> cityRepository):base(cityRepository)
        {
        }
    }
}
