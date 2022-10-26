using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Session
    {
        public Session()
        {
            Units = new HashSet<Unit>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Index { get; set; }
        public long IdSyllabus { get; set; }

        public virtual Syllabus IdSyllabusNavigation { get; set; } = null!;
        public virtual ICollection<Unit> Units { get; set; }
    }
}
