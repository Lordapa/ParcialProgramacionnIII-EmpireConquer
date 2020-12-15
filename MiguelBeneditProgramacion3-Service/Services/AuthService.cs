using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Interfaces.Repositories;
using MiguelBeneditProgramacion3_Core.Interfaces.Services;
using MiguelBeneditProgramacion3_Service.Helpers;
using System.Linq;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public class AuthService : IAuthService
    {
        public readonly IRepository<User> _userRepository;
        public AuthService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public User ValidateUserCredential(string username, string password)
        {
            var user =  _userRepository.GetAsync(w => w.Email == username).Result.FirstOrDefault();
         
            if(user != null && user.Password == EncodeHelper.EncodePassword(password)) return user;

            return null;
        }
    }
}
