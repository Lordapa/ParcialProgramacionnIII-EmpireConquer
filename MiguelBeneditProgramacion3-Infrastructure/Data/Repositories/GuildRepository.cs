using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class GuildRepository : EntityFrameworkRepository<Guild,DBEmpireContext>
    {
        public GuildRepository(DBEmpireContext context) : base(context)
        {
        }
    }
}
