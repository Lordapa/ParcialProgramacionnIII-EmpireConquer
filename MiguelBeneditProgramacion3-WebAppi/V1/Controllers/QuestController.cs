using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// Quest api controller
    /// </summary>
    public class QuestController : BaseApiController<Quest>
    {
        public QuestController(IBaseService<Quest> baseService) : base(baseService)
        {
        }
    }
}
