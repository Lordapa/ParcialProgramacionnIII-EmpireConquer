using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class EmpireRepository:EntityFrameworkRepository<Empire,DBEmpireContext>
    {
        public EmpireRepository(DBEmpireContext context):base(context)
        {
        }
    }
}
