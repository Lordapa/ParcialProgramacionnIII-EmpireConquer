using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class MapService:BaseService<Map>
    {
        public MapService(IUnitOfWork unitOfWork, IRepository<Map> mapRepository):base(unitOfWork,mapRepository)
        {
        }
    }
}
