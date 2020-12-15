using MiguelBeneditProgramacion3_Core.Entities;

namespace MiguelBeneditProgramacion3_Core.Interfaces.Services
{
    public interface IAuthService
    {
        User ValidateUserCredential(string username, string password);
    }
}
