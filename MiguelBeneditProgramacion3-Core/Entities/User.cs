namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class User : EntityBase<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName => Email;
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
