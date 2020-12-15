using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class UserRepository:EntityFrameworkRepository<User,DBEmpireContext>
    {
        public UserRepository(DBEmpireContext context):base(context)
        {
        }
    }
}
