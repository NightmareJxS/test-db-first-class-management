using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Level
    {
        public Level()
        {
            Syllabi = new HashSet<Syllabus>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Syllabus> Syllabi { get; set; }
    }
}
