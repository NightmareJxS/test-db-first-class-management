using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Unit
    {
        public Unit()
        {
            Lessons = new HashSet<Lesson>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Index { get; set; }
        public long IdSession { get; set; }

        public virtual Session IdSessionNavigation { get; set; } = null!;
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
