using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class QuestRepository:EntityFrameworkRepository<Quest,DBEmpireContext>
    {
        public QuestRepository(DBEmpireContext context):base(context)
        {

        }
    }
}
