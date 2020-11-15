using MiguelBeneditProgramacion3_Core.Enums;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName => Email;
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
    }
}
