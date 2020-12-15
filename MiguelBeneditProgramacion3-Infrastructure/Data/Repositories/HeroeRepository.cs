using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class HeroeRepository:EntityFrameworkRepository<Heroe,DBEmpireContext>
    {
        public HeroeRepository(DBEmpireContext context):base(context)
        {
        }
    }
}
