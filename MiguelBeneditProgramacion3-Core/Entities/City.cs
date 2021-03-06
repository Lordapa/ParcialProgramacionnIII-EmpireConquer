﻿using System.Text.Json.Serialization;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class City:EntityBase
    {
        public string Name { get; set; }
        public int Population { get; set; }
        [JsonIgnore]
        public Empire Empire { get; set; }
        public long EmpireId { get; set; }
        public Region Region { get; set; }
        public long RegionId { get; set; }
    }
}