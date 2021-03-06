﻿using MiguelBeneditProgramacion3_Core.Enums;
using System.Collections.Generic;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class Empire: EntityBase
    {
        public string Name { get; set; }
        public User User { get; set; }
        public long UserId { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Heroe> Heroes { get; set; }
        public RaceType Race { get; set; }
    }
}