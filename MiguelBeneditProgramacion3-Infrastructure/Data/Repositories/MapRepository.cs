using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class MapRepository : EntityFrameworkRepository<Map, DBEmpireContext>
    {
        public MapRepository(DBEmpireContext context) : base(context)
        {
        }
    }
}
