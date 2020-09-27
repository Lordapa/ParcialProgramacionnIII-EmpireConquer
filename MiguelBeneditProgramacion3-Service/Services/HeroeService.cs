using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class HeroeService : BaseService<Heroe>
    {
        public HeroeService(IUnitOfWork unitOfWork, IRepository<Heroe> heroeRepository) : base(unitOfWork, heroeRepository)
        {
        }
    }
}
