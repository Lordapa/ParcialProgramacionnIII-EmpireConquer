using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.Repositories
{
    public class CityRepository:EntityFrameworkRepository<City,DBEmpireContext>
    {
        public CityRepository(DBEmpireContext context):base(context)
        {
        }
    }
}
