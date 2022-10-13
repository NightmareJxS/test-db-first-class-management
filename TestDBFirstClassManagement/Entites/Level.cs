using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Level
    {
        public Level()
        {
            Syllabuses = new HashSet<Syllabuse>();
        }

        public long IdLevel { get; set; }
        public string? LevelName { get; set; }

        public virtual ICollection<Syllabuse> Syllabuses { get; set; }
    }
}
