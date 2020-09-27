using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class GameService : BaseService<Game>
    {
        public GameService(IUnitOfWork unitOfWork, IRepository<Game> gameRepository) : base(unitOfWork, gameRepository)
        {

        }
    }
}
