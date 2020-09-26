using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class UserService : BaseService<User>
    {
        public UserService(IRepository<User> userRepository) : base(userRepository)
        {
        }
    }
}
