using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class EmpireService:BaseService<Empire>
    {
        public EmpireService(IRepository<Empire> empireRepository):base(empireRepository)
        {
        }
    }
}
