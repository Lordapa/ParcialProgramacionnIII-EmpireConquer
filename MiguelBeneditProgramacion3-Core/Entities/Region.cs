using System.Collections.Generic;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class Region:EntityBase<long>
    {
        public string Name { get; set; }
        public IEnumerable<Ground> Grounds { get; set; }
    }
}