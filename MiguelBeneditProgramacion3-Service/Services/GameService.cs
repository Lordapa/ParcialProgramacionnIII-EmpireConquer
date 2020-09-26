using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class GameService : BaseService<Game>
    {
        public GameService(IRepository<Game> gameRepository) : base(gameRepository)
        {

        }
    }
}
