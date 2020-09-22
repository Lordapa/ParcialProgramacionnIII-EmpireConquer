using MiguelBeneditProgramación3_Core.Enums;

namespace MiguelBeneditProgramación3_Core.Entities
{
    public class Ground:EntityBase<long>
    {
        public int Name { get; set; }
        public GroundType Type { get; set; }
        public byte[] MapImage { get; set; }
    }
}