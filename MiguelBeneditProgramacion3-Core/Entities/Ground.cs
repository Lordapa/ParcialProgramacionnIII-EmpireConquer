using MiguelBeneditProgramacion3_Core.Enums;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class Ground:EntityBase
    {
        public int Name { get; set; }
        public GroundType Type { get; set; }
        public byte[] Image { get; set; }
    }
}