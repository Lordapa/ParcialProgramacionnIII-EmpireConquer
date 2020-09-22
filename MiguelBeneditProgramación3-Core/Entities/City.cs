using System;

namespace MiguelBeneditProgramación3_Core.Entities
{
    public class City:EntityBase<Guid>
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public Empire Empire { get; set; }
        public long EmpireId { get; set; }
        public Region Region { get; set; }
        public long RegionId { get; set; }
    }
}