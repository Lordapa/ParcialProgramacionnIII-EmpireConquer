using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;
using MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework;
using MiguelBeneditProgramacion3_Infrastructure.Extensions;
using MiguelBeneditProgramacion3_Service.Services;

namespace MiguelBeneditProgramacion3_Service.Extensions
{
    public static class ServicesCollectionExtension
    {
        // <summary>
        /// Add all the Empire Conquer's dependencies to the collection.
        /// </summary>
        /// <param name="service">IServiceCollection.</param>
        /// <param name="configuration">IConfiguration.</param>
        public static void AddEmpireConquerToModule(this IServiceCollection service, IConfiguration configuration) {

            service.AddEntityFramework(configuration);
            service.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork<DBEmpireContext>>();

            service.AddScoped<IBaseService<City>, CityService>();
            service.AddScoped<IBaseService<User>, UserService>();
            service.AddScoped<IBaseService<Empire>, EmpireService>();
            service.AddScoped<IBaseService<Heroe>, HeroeService>();
            service.AddScoped<IBaseService<Map>, MapService>();
            service.AddScoped<IBaseService<Quest>, QuestService>();
            service.AddScoped<IBaseService<Game>, GameService>();

        }        
    }
}
