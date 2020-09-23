namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class Quest:EntityBase<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int LevelRequired { get; set; }
    }
}
