using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class EmpireService:BaseService<Empire>
    {
        public EmpireService(IUnitOfWork unitOfWork, IRepository<Empire> empireRepository):base(unitOfWork,empireRepository)
        {
        }
    }
}
