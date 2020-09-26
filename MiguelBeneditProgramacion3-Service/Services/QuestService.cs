using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class QuestService: BaseService<Quest>
    {
        public QuestService(IRepository<Quest> questRepository):base(questRepository)
        {
        }
    }
}
