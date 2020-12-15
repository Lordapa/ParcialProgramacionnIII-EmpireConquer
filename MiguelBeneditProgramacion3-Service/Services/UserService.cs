using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;
using MiguelBeneditProgramacion3_Service.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class UserService :BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User> userRepository) : base(unitOfWork, userRepository)
        {
        }

        public override Task<User> CreateAsync(User value, string userName)
        {
            value.Password = EncodeHelper.EncodePassword(value.Password);
            return base.CreateAsync(value, userName);
        }
    }
}
