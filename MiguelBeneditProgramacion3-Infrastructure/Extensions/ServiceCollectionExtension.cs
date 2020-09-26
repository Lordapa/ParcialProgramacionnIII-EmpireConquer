using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;

namespace MiguelBeneditProgramacion3_Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddEntityFramework(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DBEmpireContext>(
                  options => options.UseSqlServer(configuration.GetConnectionString("EmpireConquer"))
                );
        }
    }
}
