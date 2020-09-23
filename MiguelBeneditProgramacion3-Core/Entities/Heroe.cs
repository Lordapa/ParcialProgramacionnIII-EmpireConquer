using MiguelBeneditProgramacion3_Core.Enums;
using System;

namespace MiguelBeneditProgramacion3_Core.Entities
{
    public class Heroe:EntityBase<Guid>
    {
        public string Name { get; set; }
        public HeroType Type { get; set; }
        public byte[] Avatar { get; set; }
        public int Level { get; set; }
        public double Experience { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public int Life { get; set; }
        public int Speed { get; set; }
        public int Moral { get; set; }
    }
}