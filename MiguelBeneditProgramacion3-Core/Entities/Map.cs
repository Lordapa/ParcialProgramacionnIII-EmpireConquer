using System.Collections.Generic;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class Map:EntityBase
    {
        public string Name { get; set; }
        public IEnumerable<Region> Regions { get; set; }
    }
}