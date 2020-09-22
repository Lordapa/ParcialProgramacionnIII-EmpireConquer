using System.Collections.Generic;

namespace MiguelBeneditProgramación3_Core.Entities
{
    public class Map:EntityBase<long>
    {
        public string Name { get; set; }
        public IEnumerable<Region> Regions { get; set; }
    }
}