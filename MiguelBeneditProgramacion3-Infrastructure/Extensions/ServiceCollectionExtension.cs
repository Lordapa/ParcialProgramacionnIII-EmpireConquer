using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;
using MiguelBeneditProgramacion3_Infrastructure.Data.Repositories;

namespace MiguelBeneditProgramacion3_Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddEntityFramework(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DBEmpireContext>(
                  options => options.UseSqlServer(configuration.GetConnectionString("EmpireConquer"))
                );

            service.AddScoped<IRepository<Game>, GameRepository>();
            service.AddScoped<IRepository<Map>, MapRepository>();
        }
    }
}
