using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class GameRepository : EntityFrameworkRepository<Game, DBEmpireContext>
    {
        public GameRepository(DBEmpireContext context) : base(context)
        {
        }
    }
}
